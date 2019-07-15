using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SpeedyTaxis
{
    public partial class UpdateForm : Form
    {
        //Mysql connection
        static string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=speedytaxis";
        MySqlConnection databaseConnection = new MySqlConnection(MYSQLConnectionString);

        // Creates Update Form
        public UpdateForm()
        {
            InitializeComponent();
            //Setting background and setting resizing to false
            this.BackgroundImage = Properties.Resources.background;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Setting maximum date for datepicker to today
            dateTimePickerDR.MaxDate = DateTime.Now;

            //Setting visibility for form components
            dateTimePickerDR.Visible = false;
            DRExplanationRichTextBox.Visible = false;
            DRTextBox.Visible = false;
            DateLabel.Visible = false;
            DisciplinaryRecordLabel.Visible = false;
            ExplanationLabel.Visible = false;
            AddARecordButtonMain.Visible = false;

            //Update Qualifications DGV properties
            UpdateQualificationsDGV.ColumnCount = 1;
            UpdateQualificationsDGV.Columns[0].Name = "Qualification";
            UpdateQualificationsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UpdateQualificationsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UpdateQualificationsDGV.MultiSelect = false;

            //Update Assigned Training DGV properties
            UFAssignedTrainingDGV.ColumnCount = 3;
            UFAssignedTrainingDGV.Columns[0].Name = "Training";
            UFAssignedTrainingDGV.Columns[1].Name = "Date";
            UFAssignedTrainingDGV.Columns[2].Name = "Status";
            UFAssignedTrainingDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UFAssignedTrainingDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UFAssignedTrainingDGV.MultiSelect = false;

            //Disciplinary Records DGV
            UFDisciplinaryRecordsDGV.ColumnCount = 3;
            UFDisciplinaryRecordsDGV.Columns[0].Name = "Date";
            UFDisciplinaryRecordsDGV.Columns[0].DefaultCellStyle.Format = "yyyy//MM//dd";
            UFDisciplinaryRecordsDGV.Columns[1].Name = "Disciplinary Record Name";
            UFDisciplinaryRecordsDGV.Columns[2].Name = "Disciplinary Record";
            UFDisciplinaryRecordsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UFDisciplinaryRecordsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UFDisciplinaryRecordsDGV.MultiSelect = false;

            //Loads the qualifications into the combobox
            LoadQualificationsIntoComboBox();
            LoadStatus();

            //Runs methods after the form has been initialised, as certain values need to be accessed once the form has loaded up. (They can't be accessed beforehand)
            this.Load += new EventHandler(Finished_Loading);
        }

        //Loads qualifiations into DGV(by getting the driver's ID) and checks for duplicates(removes them to avoid duplicate qualifications assigned)
        private void Finished_Loading(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDLabel.Text);
            LoadQualificationsIntoDGV();
            CheckForDuplicates();
            LoadPhoneNumber(ID);
            LoadAssignedTraining(ID);
            LoadDisciplinaryRecords(ID);
        }

        //Checks for duplicates by comparing values in the combobox and in the update datagridview
        private void CheckForDuplicates()
        {
            for (int i = 0; i < UpdateQualificationsDGV.Rows.Count; i++)
            {
                for (int e = 0; e < UpdateQualificationsComboBox.Items.Count; e++)
                {
                    if (UpdateQualificationsDGV.Rows[i].Cells[0].Value.ToString() == UpdateQualificationsComboBox.Items[e].ToString())
                    {
                        UpdateQualificationsComboBox.Items.Remove(UpdateQualificationsComboBox.Items[e]);
                    }
                }
            }
        }

        //Loads the phone number
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
                            PhoneNumberTextBox.SetPhoneNumber((String)reader["Phone_Number"]);
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

        //Updates the driver's first name, last name, phone number, qualifications, changes status of assigned training, disciplinary records
        private void Update(int ID, string name, string surname, string PhoneNumber)
        {

            //Checks if there is a name and surname in the textbox
            if (NameTextBox.Text == "" || SurnameTextBox.Text == "")
            {
                MessageBox.Show("Please insert First Name and Last Name.");
                return;
            }

            //Checks if the phoneNumber length is == 11
            if (PhoneNumber.Length != 11)
            {
                MessageBox.Show("Invalid Phone number. Please try again.");
                PhoneNumberTextBox.Clear();
                return;
            }

            //Update driver's name, surname, phone number
            UpdateDriver(ID, name, surname, PhoneNumber);
            //Deletes assigned qualifications
            DeleteAssignedQualifications(ID);
            //Inserts Qualifications
            InsertQualifications(ID);
            //Changes the status of assigned qualifications
            ChangeStatus(ID);
            //Deletes previous disciplinary records
            DeleteDisciplinaryRecords(ID);
            //Inserts Disciplinary Records
            InsertDisciplinaryRecords(ID);
        }

        //Update Driver's name, surname, phone number
        private void UpdateDriver(int ID, string name, string surname, string PhoneNumber)
        {

            //Updates the driver's name, surname
            string query = "UPDATE `driver` SET `first_Name`= '" + name + "', `last_Name`= '" + surname + "' ,`Phone_Number`= '" + PhoneNumber + "' WHERE id = " + ID;
            try
            {
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.UpdateCommand = databaseConnection.CreateCommand();
                        adapter.UpdateCommand.CommandText = query;
                        adapter.UpdateCommand.ExecuteNonQuery();
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Deletes assigned qualifications
        private void DeleteAssignedQualifications(int ID)
        {
            try
            {
                string deleteQuery = "DELETE FROM assigned_qualification WHERE ID = " + ID + "";
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, databaseConnection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.DeleteCommand = databaseConnection.CreateCommand();
                        adapter.DeleteCommand.CommandText = deleteQuery;
                        cmd.ExecuteNonQuery();
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Inserts assigned qualifications into the database
        private void InsertQualifications(int ID)
        {
            MySqlDataReader reader = null;
            var Qualification_ID = new List<int>();
            try
            {
                databaseConnection.Open();
                foreach (DataGridViewRow row in UpdateQualificationsDGV.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < UpdateQualificationsDGV.Columns.Count; i++)
                        {
                            String Qualification = Convert.ToString(row.Cells[i].Value);
                            string selectQuery = "SELECT `Qualification_ID`FROM `qualification` WHERE `Qualification` LIKE '" + Qualification + "'";
                            using (MySqlCommand cmd = new MySqlCommand(selectQuery, databaseConnection))
                            {
                                reader = cmd.ExecuteReader();

                                while (reader.Read())
                                {
                                    Qualification_ID.Add((int)reader["Qualification_ID"]);
                                }
                            }
                        }
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                databaseConnection.Open();
                for (int i = 0; i < Qualification_ID.Count; i++)
                {
                    MySqlCommand cmd2 = databaseConnection.CreateCommand();
                    //Inserts the qualifications
                    cmd2.CommandText = "INSERT INTO `assigned_qualification` (`id`, `Qualification_ID`) VALUES(@id, @qualification_id)";
                    cmd2.Parameters.AddWithValue("@id", ID);
                    cmd2.Parameters.AddWithValue("@qualification_id", Qualification_ID[i]);
                    cmd2.ExecuteNonQuery();
                }
                Qualification_ID.Clear();
                databaseConnection.Close();
                MessageBox.Show("Successfully Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Loads the driver's qualifications in case there are any (This can be written more efficiently, no need for so many queries, can just use one for all)
        private void LoadQualificationsIntoDGV()
        {
            var Qualification_ID = new List<int>();
            //Selects the qualification id where theres an id assigned to it
            string selectQuery = "SELECT `Qualification_ID` FROM `assigned_qualification` WHERE `id` = '" + Convert.ToInt32(IDLabel.Text) + "'";
            try
            {
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, databaseConnection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Qualification_ID.Add((int)reader["Qualification_ID"]);
                        }
                    }
                }
                for (int i = 0; i < Qualification_ID.Count; i++)
                {
                    //Selects the qualification from qualifications where qualification id is this
                    string query = "SELECT `Qualification` FROM `qualification` WHERE `Qualification_ID` = '" + Qualification_ID[i] + "'";
                    using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UpdateQualificationsDGV.Rows.Add(reader.GetString("qualification"));
                            }
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

        //Loads the qualifications from the database into the combobox
        private void LoadQualificationsIntoComboBox()
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
                            UpdateQualificationsComboBox.Items.Add(reader.GetString("qualification"));
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

        //Adds the qualification to the datagridview and removes it from the combobox
        private void UpdateQualificationsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateQualificationsDGV.Rows.Add(UpdateQualificationsComboBox.Text);
            UpdateQualificationsComboBox.Items.Remove(UpdateQualificationsComboBox.Text);
        }

        //Update button listener
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //gets the values from the setLabel(ID), name and surname
            Update(Convert.ToInt32(IDLabel.Text), NameTextBox.Text, SurnameTextBox.Text, PhoneNumberTextBox.GetPhoneNumber());
        }

        //Removes the qualification from datagridview and adds it to the combobox
        private void RemoveQualificationBtn_Click(object sender, EventArgs e)
        {
            UpdateQualificationsComboBox.Items.Add(UpdateQualificationsDGV.CurrentCell.Value.ToString());
            UpdateQualificationsDGV.Rows.RemoveAt(UpdateQualificationsDGV.SelectedRows[0].Index);
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
                            UFAssignedTrainingDGV.Rows.Add(reader.GetString("Training_Type"), reader.GetString("Date"), reader.GetString("Status"));
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

        //Load ComboBox with status
        private void LoadStatus()
        {
            string query = "SELECT `Status` FROM `training_status` WHERE 1";
            try
            {
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UFAssignedTrainingComboBox.Items.Add(reader.GetString("Status"));
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

        //if something is selected from the combobox, the value changes on the selected datagridview row to the value that is in the combobox
        private void UFAssignedTrainingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in UFAssignedTrainingDGV.SelectedRows)
                UFAssignedTrainingDGV.Rows[row.Index].Cells["Status"].Value = UFAssignedTrainingComboBox.SelectedItem.ToString();
        }

        //Updates the value of the combobox whenever a different row is selected
        private void UFAssignedTrainingDGV_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in UFAssignedTrainingDGV.SelectedRows)
                UFAssignedTrainingComboBox.Text = (String)UFAssignedTrainingDGV.Rows[row.Index].Cells["Status"].Value;
        }

        //Changes the status of the assigned training
        private void ChangeStatus(int ID)
        {
            var Assigned_Training_ID = new List<int>();
            //Selects the assigned training IDs
            string selectQuery = "SELECT `Assigned_Training_ID` FROM `assigned_training` WHERE ID = " + ID;
            try
            {
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, databaseConnection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Adds them to a list
                            Assigned_Training_ID.Add((int)reader["Assigned_Training_ID"]);
                        }
                    }

                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                databaseConnection.Open();
                for (int i = 0; i < Assigned_Training_ID.Count; i++)
                {
                    using (MySqlCommand cmd = new MySqlCommand(null, databaseConnection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            //Poor way of handling the status in the database (hardcoding)
                            int status = 0;
                            if ((String)UFAssignedTrainingDGV.Rows[i].Cells["Status"].Value == "Waiting") status = 1;
                            else if ((String)UFAssignedTrainingDGV.Rows[i].Cells["Status"].Value == "Successful") status = 2;
                            else status = 3;
                            //Updates the database with the statuses
                            string query = "UPDATE `assigned_training` SET `Training_Status_ID` = '" + status + "' WHERE Assigned_Training_ID = '" + Assigned_Training_ID[i] + "'";
                            adapter.UpdateCommand = databaseConnection.CreateCommand();
                            adapter.UpdateCommand.CommandText = query;
                            adapter.UpdateCommand.ExecuteNonQuery();
                        }
                    }
                }
                Assigned_Training_ID.Clear();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Cell formatting for Success, failed, waiting colors
        private void UFAssignedTrainingDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (UFAssignedTrainingDGV.Rows[e.RowIndex].Cells[2].Value.ToString() == "Successful")
            {
                UFAssignedTrainingDGV.Rows[e.RowIndex].Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.Green };
            }
            else if (UFAssignedTrainingDGV.Rows[e.RowIndex].Cells[2].Value.ToString() == "Failed")
            {
                UFAssignedTrainingDGV.Rows[e.RowIndex].Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
            }
            else UFAssignedTrainingDGV.Rows[e.RowIndex].Cells[2].Style = new DataGridViewCellStyle { ForeColor = Color.Orange };
        }

        //Loads disciplinary records into the DGV
        private void LoadDisciplinaryRecords(int ID)
        {
            string selectQuery = "SELECT `Date`, `Disciplinary_Record_Name`, `Disciplinary_Record` FROM `Disciplinary_Record` WHERE ID = " + ID;
            try
            {
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, databaseConnection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime date = Convert.ToDateTime(reader.GetString("Date"));
                            DateTime dateOnly = date.Date;
                            UFDisciplinaryRecordsDGV.Rows.Add(dateOnly, reader.GetString("Disciplinary_Record_Name"), reader.GetString("Disciplinary_Record"));
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

        //Loads the Record disciplinary record components
        private void AddDRecordButton_Click(object sender, EventArgs e)
        {
            //Manages the visibility and the form to accommodate the add disciplinary record
            this.Size = new Size(745, 663);
            AddDRecordButton.Visible = false;
            UpdateButton.Visible = false;
            dateTimePickerDR.Visible = true;
            DRExplanationRichTextBox.Visible = true;
            DRTextBox.Visible = true;
            DateLabel.Visible = true;
            DisciplinaryRecordLabel.Visible = true;
            ExplanationLabel.Visible = true;
            AddARecordButtonMain.Visible = true;
        }

        // Removes the components and adds the record to the DGV
        private void AddARecordButtonMain_Click(object sender, EventArgs e)
        {
            //If no disciplinary record name or explanation is provided
            if (GetDRName() == "" || GetDRExplanation() == "")
            {
                MessageBox.Show("Please insert Disciplinary Record name and explanation.");
                return;
            }
            else
            {
                //Manages the visibility and the form to accommodate the add disciplinary record
                UFDisciplinaryRecordsDGV.Rows.Add(GetDate(), GetDRName(), GetDRExplanation());
                this.Size = new Size(480, 715);
                AddDRecordButton.Visible = true;
                UpdateButton.Visible = true;
                dateTimePickerDR.Visible = false;
                DRExplanationRichTextBox.Visible = false;
                DRTextBox.Visible = false;
                DateLabel.Visible = false;
                DisciplinaryRecordLabel.Visible = false;
                ExplanationLabel.Visible = false;
                AddARecordButtonMain.Visible = false;
                MessageBox.Show("Record added. Please click Update to finalise.");
            }
        }

        //Inserts disciplinary records into the database
        private void InsertDisciplinaryRecords(int ID)
        {
            try
            {
                databaseConnection.Open();
                foreach (DataGridViewRow row in UFDisciplinaryRecordsDGV.Rows)
                {
                    MySqlCommand cmd = databaseConnection.CreateCommand();
                    //The third query inserts the qualifications and assigns them to that driver's ID
                    cmd.CommandText = "INSERT INTO `disciplinary_record` (`id`, `Date`, `Disciplinary_Record_Name`, `Disciplinary_Record`) VALUES(@id, @Date, @Disciplinary_Record_Name, @Disciplinary_Record)";
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@Date", UFDisciplinaryRecordsDGV.Rows[row.Index].Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@Disciplinary_Record_Name", UFDisciplinaryRecordsDGV.Rows[row.Index].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@Disciplinary_Record", UFDisciplinaryRecordsDGV.Rows[row.Index].Cells[2].Value.ToString());
                    cmd.ExecuteNonQuery();
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Deletes disciplinary records
        private void DeleteDisciplinaryRecords(int ID)
        {
            try
            {
                string query = "DELETE FROM Disciplinary_Record WHERE ID = " + ID + "";
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.DeleteCommand = databaseConnection.CreateCommand();
                        adapter.DeleteCommand.CommandText = query;
                        cmd.ExecuteNonQuery();
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Gets the date value from the datepicker
        private String GetDate()
        {
            return dateTimePickerDR.Value.ToShortDateString();
        }

        //Gets the discplinary record name from the textbox
        private String GetDRName()
        {
            return DRTextBox.Text;
        }

        //Gets the discplinary record explanation from the textbox
        private String GetDRExplanation()
        {
            return DRExplanationRichTextBox.Text;
        }

        //Opens disciplinary record if double clicked
        private void UFDisciplinaryRecordsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DisciplinaryRecordForm DisciplinaryRecordForm = new DisciplinaryRecordForm();
            DisciplinaryRecordForm.NameLabel.Text = NameTextBox.Text;
            DisciplinaryRecordForm.DateLabel.Text = UFDisciplinaryRecordsDGV.CurrentRow.Cells[0].Value.ToString();
            DisciplinaryRecordForm.DisciplinaryRecordNameLabel.Text = UFDisciplinaryRecordsDGV.CurrentRow.Cells[1].Value.ToString();
            DisciplinaryRecordForm.DisciplinaryRecordExplanation.Text = UFDisciplinaryRecordsDGV.CurrentRow.Cells[2].Value.ToString();
            DisciplinaryRecordForm.ShowDialog();
        }
    }

}
