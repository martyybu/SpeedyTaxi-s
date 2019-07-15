using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedyTaxis
{
    public partial class ProfileForm : Form
    {        
        //Mysql connection
        static string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=speedytaxis";
        MySqlConnection databaseConnection = new MySqlConnection(MYSQLConnectionString);

        public ProfileForm()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.background;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Qualifications DGV properties
            PFQualificationsDGV.ColumnCount = 1;
            PFQualificationsDGV.Columns[0].Name = "Qualification";
            PFQualificationsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PFQualificationsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PFQualificationsDGV.MultiSelect = false;

            //Assigned Training DGV properties
            PFAssignedTrainingDGV.ColumnCount = 3;
            PFAssignedTrainingDGV.Columns[0].Name = "Training";
            PFAssignedTrainingDGV.Columns[1].Name = "Date";
            PFAssignedTrainingDGV.Columns[2].Name = "Status";
            PFAssignedTrainingDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PFAssignedTrainingDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PFAssignedTrainingDGV.MultiSelect = false;

            //Disciplinary records DGV properties
            DisciplinaryRecordsDGV.ColumnCount = 3;
            DisciplinaryRecordsDGV.Columns[0].Name = "Date";
            DisciplinaryRecordsDGV.Columns[0].DefaultCellStyle.Format = "yyyy//MM//dd";
            DisciplinaryRecordsDGV.Columns[1].Name = "Disciplinary Record";
            DisciplinaryRecordsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DisciplinaryRecordsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DisciplinaryRecordsDGV.MultiSelect = false;


            //Runs methods after the form has been initialised, as certain values need to be accessed once the form has loaded up. (They can't be accessed beforehand)
            this.Load += new EventHandler(Finished_Loading);
        }

        //Loads qualifiations into DGV(by getting the driver's ID) and checks for duplicates(removes them to avoid duplicate qualifications assigned)
        private void Finished_Loading(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(setIDLabel.Text);
            LoadPhoneNumber(ID);
            LoadQualifications(ID);
            LoadAssignedTraining(ID);
            LoadDisciplinaryRecords(ID);
        }

        //Loads the phone number by ID
        private void LoadPhoneNumber(int ID)
        {
            string query = "SELECT `Phone_Number` FROM `driver` WHERE id = '" + ID + "'";
            try
            {
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            setPhoneNumberLabel.Text = (String)reader["Phone_Number"];
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

        //Loads Qualifications
        private void LoadQualifications(int ID)
        {
            string query = "SELECT `qualification` FROM `assigned_qualification` INNER JOIN `qualification` USING(`Qualification_ID`) WHERE id = " + ID;
            try
            {
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PFQualificationsDGV.Rows.Add(reader.GetString("qualification"));
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

        //Loads assigned training
        private void LoadAssignedTraining(int ID)
        {
            string query = "SELECT `Training_Type`, `Date`, `Status` FROM `assigned_training` INNER JOIN `session` USING(`Session_ID`) INNER JOIN `training_type` ON session.Training_Type_ID = training_type.Training_Type_ID INNER JOIN `training_status` USING(`Training_Status_ID`) WHERE `id` = " + ID;
            try
            {
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PFAssignedTrainingDGV.Rows.Add(reader.GetString("Training_Type"), reader.GetString("Date"), reader.GetString("Status"));
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

        //Loads Disciplinary Records
        private void LoadDisciplinaryRecords(int ID)
        {
            string query = "SELECT `Date`, `Disciplinary_Record_Name`, `Disciplinary_Record` FROM `Disciplinary_Record` WHERE ID = " + ID;
            try
            {
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime date = Convert.ToDateTime(reader.GetString("Date"));
                            DateTime dateOnly = date.Date;
                            DisciplinaryRecordsDGV.Rows.Add(dateOnly, reader.GetString("Disciplinary_Record_Name"), reader.GetString("Disciplinary_Record"));
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

        //Colours the Status of the training
        private void PFAssignedTrainingDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (PFAssignedTrainingDGV.Rows[e.RowIndex].Cells[2].Value.ToString() == "Successful")
            {
                PFAssignedTrainingDGV.Rows[e.RowIndex].Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.Green};
            }
            else if (PFAssignedTrainingDGV.Rows[e.RowIndex].Cells[2].Value.ToString() == "Failed")
            {
                PFAssignedTrainingDGV.Rows[e.RowIndex].Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
            }
            else PFAssignedTrainingDGV.Rows[e.RowIndex].Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.Orange};
        }

        //Opens disciplinary record full description when double clicked on a disciplinary records DGV row
        private void DisciplinaryRecordsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DisciplinaryRecordForm DisciplinaryRecordForm = new DisciplinaryRecordForm();
            DisciplinaryRecordForm.NameLabel.Text = setNameLabel.Text;
            DisciplinaryRecordForm.DateLabel.Text = DisciplinaryRecordsDGV.CurrentRow.Cells[0].Value.ToString();
            DisciplinaryRecordForm.DisciplinaryRecordNameLabel.Text = DisciplinaryRecordsDGV.CurrentRow.Cells[1].Value.ToString();
            DisciplinaryRecordForm.DisciplinaryRecordExplanation.Text = DisciplinaryRecordsDGV.CurrentRow.Cells[2].Value.ToString();
            DisciplinaryRecordForm.ShowDialog();
        }

        //Closes the Profile Form
        private void PFOKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
