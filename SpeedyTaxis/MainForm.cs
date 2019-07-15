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
    public partial class MainForm : Form
    {
        //Setting the MYSQL connection
        static string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=speedytaxis";
        MySqlConnection databaseConnection = new MySqlConnection(MYSQLConnectionString);

        public MainForm()
        {
            InitializeComponent();

            //Sets background and disallows for the admin to resize the form
            this.BackgroundImage = Properties.Resources.background;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Sets up Driver gridview properties
            DriverDataGridView.ColumnCount = 4;
            DriverDataGridView.Columns[0].Name = "ID";
            DriverDataGridView.Columns[1].Name = "Name";
            DriverDataGridView.Columns[2].Name = "Surname";
            DriverDataGridView.Columns[3].Name = "Phone Number";
            DriverDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DriverDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DriverDataGridView.MultiSelect = false;

            //Retrieves drivers from the database
            RetrieveDrivers();
        }

        //Populates the GridView with drivers that are taken from the database
        private void Populate(String id, String name, String surname, String PhoneNumber)
        {
            DriverDataGridView.Rows.Add(id, name, surname, PhoneNumber);
        }

        //Retrieves drivers from the database
        private void RetrieveDrivers()
        {
            DriverDataGridView.Rows.Clear();
            string query = "SELECT * FROM Driver";
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
                            Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                        }
                        dt.Rows.Clear();
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Retrieve drivers problem. Message: " + ex.Message);
            }
        }

        //Opens Add Driver Form
        private void Add_Click(object sender, EventArgs e)
        {
            var AddForm = new AddForm();
            AddForm.Show();
        }

        //Deletes a driver from a datagridview, delete button listener
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string selected = DriverDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            Delete(id);
        }

        //Delete method for delete button, removes all of the records from the database
        private void Delete(int ID)
        {
            DeleteAssignedQualifications(ID);
            DeleteAssignedTraining(ID);
            DeleteDisciplinaryRecords(ID);
            DeleteDriver(ID);
        }

        //Deletes assigned qualifications
        private void DeleteAssignedQualifications(int ID)
        {
            try
            {
                //1. Deletes the assigned qualifications
                string deleteAssignedQualifications = "DELETE FROM assigned_qualification WHERE ID = " + ID + "";
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(deleteAssignedQualifications, databaseConnection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        //Delete qualifications
                        adapter.DeleteCommand = databaseConnection.CreateCommand();
                        adapter.DeleteCommand.CommandText = deleteAssignedQualifications;
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

        //Deletes assigned training
        private void DeleteAssignedTraining(int ID)
        {
            try
            {
                //2. Deletes all assigned training
                string deleteAssignedTraining = "DELETE FROM assigned_training WHERE ID = " + ID + "";
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(deleteAssignedTraining, databaseConnection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        //Delete qualifications
                        adapter.DeleteCommand = databaseConnection.CreateCommand();
                        adapter.DeleteCommand.CommandText = deleteAssignedTraining;
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

        //Deletes disciplinary records
        private void DeleteDisciplinaryRecords(int ID)
        {
            try
            {
                //3. Deletes the disciplinary records
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

        //Deletes the driver
        private void DeleteDriver(int ID)
        {
            //4. Deletes the Driver.
            string deleteQuery = "DELETE FROM Driver WHERE ID = " + ID;
            try
            {
                databaseConnection.Open();
                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, databaseConnection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.DeleteCommand = databaseConnection.CreateCommand();
                        adapter.DeleteCommand.CommandText = deleteQuery;
                        if (MessageBox.Show("Are you sure?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                deleteQuery = "DELETE FROM assigned_qualification WHERE ID = " + ID + "";
                                adapter.DeleteCommand = databaseConnection.CreateCommand();
                                adapter.DeleteCommand.CommandText = deleteQuery;
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Successfully deleted");
                            }
                        }
                    }
                }
                databaseConnection.Close();
                RetrieveDrivers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete problem. Message: " + ex.Message);
            }
        }

        //Opens Update Driver Form, sets up the values
        private void UpdateFormButton_Click(object sender, EventArgs e)
        {
            var UpdateForm = new UpdateForm();
            UpdateForm.IDLabel.Text = DriverDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            UpdateForm.NameTextBox.Text = DriverDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            UpdateForm.SurnameTextBox.Text = DriverDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            UpdateForm.Show();
        }

        //Refreshes the driver list
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RetrieveDrivers();
        }

        //Searches the gridview for any values similar to what was put in the search textbox
        public void SearchData(string valueToSearch)
        {
            string query = "SELECT * FROM Driver WHERE CONCAT(`id`, `first_Name`, `last_Name`) like '%" + valueToSearch + "%'";
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
                            Populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                        }
                        dt.Rows.Clear();
                    }
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search problem. Message: " + ex.Message);
            }
        }

        //Reacts immediately on any change in the search textbox
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            DriverDataGridView.Rows.Clear();
            string valueToSearch = SearchTextBox.Text.ToString();
            SearchData(valueToSearch);
        }

        //Opens Assign Training Form, sets up the values
        private void AssignTrainingButton_Click(object sender, EventArgs e)
        {
            var AssignTrainingForm = new AssignTrainingForm();
            AssignTrainingForm.ATidLabel.Text = DriverDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            AssignTrainingForm.ATnameLabel.Text = DriverDataGridView.SelectedRows[0].Cells[1].Value.ToString() + " " + DriverDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            AssignTrainingForm.Show();
        }

        //Opens Create Session Form
        private void CreateSessionBtn_Click(object sender, EventArgs e)
        {
            var CreateSessionForm = new CreateSessionForm();
            CreateSessionForm.Show();
        }

        //Opens Profile when a cell in DGV is double clicked
        private void DriverDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var ProfileForm = new ProfileForm();
            ProfileForm.setIDLabel.Text = DriverDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            ProfileForm.setNameLabel.Text = DriverDataGridView.SelectedRows[0].Cells[1].Value.ToString() + " " + DriverDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            ProfileForm.Show();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            var LogForm = new LogForm();
            LogForm.Show();
        }
    }
}
