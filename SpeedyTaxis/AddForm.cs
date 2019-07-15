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
    public partial class AddForm : Form
    {
        //Setting the MYSQL connection
        static string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=speedytaxis";
        MySqlConnection databaseConnection = new MySqlConnection(MYSQLConnectionString);

        //Properties for Add Form
        public AddForm()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.background;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Sets up gridview properties
            AddQualificationsGridView.ColumnCount = 1;
            AddQualificationsGridView.Columns[0].Name = "Qualification";
            AddQualificationsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AddQualificationsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AddQualificationsGridView.MultiSelect = false;

            //Load Qualifications
            LoadQualifications();
        }

        //Loads Qualifications from the database
        private void LoadQualifications()
        {
            String query = "SELECT * FROM `qualification`";
            try
            {
                    databaseConnection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AddQualificationsComboBox.Items.Add(reader.GetString("qualification"));
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

        //Add button listener, inserts the driver in the database
        private void AddBtn_Click(object sender, EventArgs e)
        {
            InsertDriver();
        }

        //Inserts the driver in the database
        private void InsertDriver()
        {
            //Gets the textbox values
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string phoneNumber = PhoneNumberTextBox.GetPhoneNumber();

            //Checks if First Name textbox and Last Name textbox are empty
            if (FirstNameTextBox.Text == "" || LastNameTextBox.Text == "")
            {
                MessageBox.Show("Please insert First Name and Last Name.");
                return;
            }
            //Checks if the phoneNumber length is == 11
            if (phoneNumber.Length != 11)
            {
                MessageBox.Show("Invalid Phone number. Please try again.");
                PhoneNumberTextBox.Clear();
                return;
            }

            //The first query inserts the Driver's name and surname
            String query = "INSERT INTO `driver`(`first_Name`, `last_Name`, `Phone_Number`) VALUES('" + firstName + "','" + lastName + "','" + phoneNumber + "')";
            var Qualification_ID = new List<int>();

            try
            {
                MySqlDataReader reader = null;
                databaseConnection.Open();
                MySqlCommand getID = databaseConnection.CreateCommand();
                getID.CommandText = query;
                getID.ExecuteNonQuery();
                //Get last inserted ID. Using this ID we insert the driver's qualifications
                long ID = getID.LastInsertedId;
                MessageBox.Show("Driver successfully added. Name: " + firstName +  " " + lastName + ", " + phoneNumber + " ID: " + ID + ".");
                databaseConnection.Close();

                foreach (DataGridViewRow row in AddQualificationsGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < AddQualificationsGridView.Columns.Count; i++)
                        {
                            String Qualification = Convert.ToString(row.Cells[i].Value);
                            //The second query selects the qualifications
                            query = "SELECT `Qualification_ID`FROM `qualification` WHERE `Qualification` LIKE '" + Qualification + "'";
                            databaseConnection.Open();
                            using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection))
                            {
                                reader = cmd.ExecuteReader();

                                while (reader.Read())
                                {
                                    Qualification_ID.Add((int)reader["Qualification_ID"]);

                                }
                                databaseConnection.Close();
                                foreach (int e in Qualification_ID)
                                {
                                    databaseConnection.Open();
                                    MySqlCommand cmd2 = databaseConnection.CreateCommand();
                                    //The third query inserts the qualifications and assigns them to that driver's ID
                                    cmd2.CommandText = "INSERT INTO `assigned_qualification` (`id`, `Qualification_ID`) VALUES(@id, @qualification_id)";
                                    cmd2.Parameters.AddWithValue("@id", ID);
                                    cmd2.Parameters.AddWithValue("@qualification_id", Qualification_ID[0]);
                                    cmd2.ExecuteNonQuery();
                                    databaseConnection.Close();
                                    }
                                Qualification_ID.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Add button error: " + e.Message);
            }
        }

        //Add Qualifications to the gridview and remove from the combobox
        private void QualificationsComboBoxAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            AddQualificationsGridView.Rows.Add(AddQualificationsComboBox.Text);
            AddQualificationsComboBox.Items.Remove(AddQualificationsComboBox.Text);
        }

        //Remove qualifications from the gridview and add them to the combobox
        private void RemoveQualificationButton_Click(object sender, EventArgs e)
        {
            AddQualificationsComboBox.Items.Add(AddQualificationsGridView.CurrentCell.Value.ToString());
            AddQualificationsGridView.Rows.RemoveAt(AddQualificationsGridView.SelectedRows[0].Index);
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}
