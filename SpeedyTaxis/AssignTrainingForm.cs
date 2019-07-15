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
    public partial class AssignTrainingForm : Form
    {
        // MYSQL connection
        static string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=speedytaxis";
        MySqlConnection databaseConnection = new MySqlConnection(MYSQLConnectionString);
        public AssignTrainingForm()
        {
            InitializeComponent();
            //Background image
            this.BackgroundImage = Properties.Resources.background;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Available sessions DGV properties
            ATdataGridViewAvailabeSessions.ColumnCount = 3;
            ATdataGridViewAvailabeSessions.Columns[0].Name = "SID";
            ATdataGridViewAvailabeSessions.Columns[1].Name = "Training Type";
            ATdataGridViewAvailabeSessions.Columns[2].Name = "Session Date";
            ATdataGridViewAvailabeSessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ATdataGridViewAvailabeSessions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ATdataGridViewAvailabeSessions.MultiSelect = false;

            //Assigned sessions DGV properties
            ATDataGridViewAssignedSessions.ColumnCount = 3;
            ATDataGridViewAssignedSessions.Columns[0].Name = "SID";
            ATDataGridViewAssignedSessions.Columns[1].Name = "Training Type";
            ATDataGridViewAssignedSessions.Columns[2].Name = "Session Date";
            ATDataGridViewAssignedSessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ATDataGridViewAssignedSessions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ATDataGridViewAssignedSessions.MultiSelect = false;

            //Retrieves sessions
            RetrieveSessions();

            //Loads this after the form has finished loading (some code has to be executed after the form has been fully loaded)
            this.Load += new EventHandler(Finished_Loading);
        }

        //Loads assigned training if there are any and checks for duplicates (if the session has already been assigned to the driver)
        private void Finished_Loading(object sender, EventArgs e)
        {
            LoadDriverAssignedTraining();
            CheckForExpiredSessions();
            CheckForDuplicates();
        }

        //Checks for expired sessions. This took a while to figure out, because the rows counts change since we are removing them
        private void CheckForExpiredSessions()
        {
            DateTime currentDateTime = DateTime.Now;

            //Searching in available sessions DGV
            for (int i = -1; ATdataGridViewAvailabeSessions.RowCount > i; i++)
            {
                for (int j = 0; ATdataGridViewAvailabeSessions.RowCount > j; j++)
                {
                    DateTime expirationDateTime = Convert.ToDateTime(ATdataGridViewAvailabeSessions.Rows[j].Cells[2].Value.ToString());
                    int result = DateTime.Compare(currentDateTime, expirationDateTime);
                    if (result <= 0) { }
                    else
                    {
                        ATdataGridViewAvailabeSessions.Rows.RemoveAt(j);
                    }
                }
            }

            //Searching in assigned sessions DGV
            for (int i = -1; ATDataGridViewAssignedSessions.RowCount > i; i++)
            {
                for (int j = 0; ATDataGridViewAssignedSessions.RowCount > j; j++)
                {
                    DateTime expirationDateTime = Convert.ToDateTime(ATDataGridViewAssignedSessions.Rows[j].Cells[2].Value.ToString());
                    int result = DateTime.Compare(currentDateTime, expirationDateTime);
                    if (result <= 0) { }
                    else
                    {
                        ATDataGridViewAssignedSessions.Rows.RemoveAt(j);
                    }
                }
            }
        }

        //Populates the available sessions gridview with the sessions from the database
        private void Populate(String session_id, String training_type, String session_Date)
        {
            ATdataGridViewAvailabeSessions.Rows.Add(session_id, training_type, session_Date);
        }

        //Retrieves sessions from the database
        private void RetrieveSessions()
        {

            string query = "SELECT `Session_ID`, `Training_Type`, `Date` FROM `session` INNER JOIN `training_type` USING (`Training_Type_ID`)";
            try
            {
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, databaseConnection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            Populate(row[0].ToString(), row[1].ToString(), row[2].ToString());
                        }
                        dt.Rows.Clear();
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrieve Sessions Problem. Message: " + ex.Message);
            }
        }

        //Loads Assigned Training
        private void LoadDriverAssignedTraining()
        {
            string selectQuery = "SELECT `Session_ID`, `Training_Type`, `Date` FROM `assigned_training` INNER JOIN `session` USING (`Session_ID`) INNER JOIN `training_type` ON session.Training_Type_ID = training_type.Training_Type_ID WHERE `id` = '" + Convert.ToInt32(ATidLabel.Text) + "'";
            try
            {
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, databaseConnection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ATDataGridViewAssignedSessions.Rows.Add(reader.GetString("Session_ID"), reader.GetString("Training_Type"), reader.GetString("Date"));
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

        //Assign training button listener
        private void AddTrainingBtn_Click(object sender, EventArgs e)
        {
            AssignTraining();
        }

        //Remove Training button listener
        private void RemoveTrainingBtn_Click_1(object sender, EventArgs e)
        {
            RemoveTraining();
        }

        //Adds the row to assigned sessions and removes it from available sessions
        private void AssignTraining()
        {
            foreach (DataGridViewRow row in ATdataGridViewAvailabeSessions.SelectedRows.Cast<DataGridViewRow>().ToList())
            {
                ATDataGridViewAssignedSessions.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value);
                ATdataGridViewAvailabeSessions.Rows.RemoveAt(row.Index);
            }
        }

        //Adds the row to available sessions and removes it from assigned sessions
        private void RemoveTraining()
        {
            foreach (DataGridViewRow row in ATDataGridViewAssignedSessions.SelectedRows.Cast<DataGridViewRow>().ToList())
            {
                ATdataGridViewAvailabeSessions.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value);
                ATDataGridViewAssignedSessions.Rows.RemoveAt(row.Index);
            }
        }

        //Checks for duplicates in the datagridviews
        private void CheckForDuplicates()
        {
            int TotalRowCount = ATDataGridViewAssignedSessions.RowCount + ATdataGridViewAvailabeSessions.RowCount;
            int j = 0, k = 0;

            for (int i = 0; TotalRowCount > i; i++)
            {
                while (ATdataGridViewAvailabeSessions.RowCount > j)
                {
                    while (ATDataGridViewAssignedSessions.RowCount > k)
                    {
                        if (ATDataGridViewAssignedSessions.Rows[k].Cells[0].Value.ToString() == ATdataGridViewAvailabeSessions.Rows[j].Cells[0].Value.ToString())
                        {
                            ATdataGridViewAvailabeSessions.Rows.RemoveAt(j);
                        }
                        k++;
                    }
                    k = 0;
                    j++;
                }
                j = 0;
            }
        }

        //Inserts assigned training into the database
        private void InsertAssignedTraining()
        {
            string ID = ATidLabel.Text;

            try
            {
                //Deletes all previous assigned training
                string deleteQuery = "DELETE FROM assigned_training WHERE ID = " + ID + "";
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, databaseConnection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        //Delete qualifications
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

            //Inserts assigned training for each row in the assigned sessions
            foreach (DataGridViewRow row in ATDataGridViewAssignedSessions.Rows)
            {
                try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = databaseConnection.CreateCommand();
                    cmd.CommandText = "INSERT INTO `assigned_training` (`id`, `Session_ID`, `Training_Status_ID`) VALUES (@id, @Session_ID, @Training_Status_ID)";
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@Session_ID", row.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@Training_Status_ID", 1);
                    cmd.ExecuteNonQuery();
                    databaseConnection.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Add button error: " + e.Message);
                }
            }
            MessageBox.Show("Training Successfully Assigned To: " + ATnameLabel.Text + ", ID: " + ID + ".");
        }

        //Assign training button listener
        private void AssignTrainingBtn_Click(object sender, EventArgs e)
        {
            InsertAssignedTraining();
        }
    }
}
