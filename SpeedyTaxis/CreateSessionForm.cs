using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SpeedyTaxis
{
    public partial class CreateSessionForm : Form
    {
        //Setting the MYSQL connection
        static string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=speedytaxis";
        MySqlConnection databaseConnection = new MySqlConnection(MYSQLConnectionString);
        int Training_Type_ID;

        //Creates the session form
        public CreateSessionForm()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.background;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Datepicker properties
            ATDateTimePicker.Format = DateTimePickerFormat.Custom;
            ATDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            //Minimum date allowed today only
            ATDateTimePicker.MinDate = DateTime.Now;

            //Loads training types
            LoadTrainingTypes();
        }

        //Selects training types from the database
        private void LoadTrainingTypes()
        {
            String query = "SELECT * FROM `training_type`";
            try
            {
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ATComboBox.Items.Add(reader.GetString("training_type"));
                        }
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Creates the session and inserts it into the database
        private void CreateSession()
        {
            MySqlDataReader reader = null;
            //Selects the Training type from the database that looks like the one in the combobox
            if (ATComboBox.SelectedItem == null) {
                MessageBox.Show("Please select a training type");
                return;
            }
            string query = "SELECT `Training_Type_ID`FROM `training_type` WHERE `Training_Type` LIKE '" + ATComboBox.SelectedItem.ToString() + "'";
            try
            {
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection))
                {
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Training_Type_ID = (int)reader["Training_Type_ID"];
                    }
                }
                MySqlCommand cmd2 = databaseConnection.CreateCommand();
                //Inserts the session
                cmd2.CommandText = "INSERT INTO `session` (`Training_Type_ID`, `Date`) VALUES(@Training_Type_ID, @Date)";
                cmd2.Parameters.AddWithValue("@Training_Type_ID", Training_Type_ID);
                cmd2.Parameters.AddWithValue("@Date", ATDateTimePicker.Value);
                cmd2.ExecuteNonQuery();
                databaseConnection.Close();
                MessageBox.Show("Inserted successfully. Training type ID: " + Training_Type_ID + ", Date: " + ATDateTimePicker.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Create session button listener
        private void CreateSessionBtn_Click(object sender, EventArgs e)
        {
            CreateSession();
        }
    }
}