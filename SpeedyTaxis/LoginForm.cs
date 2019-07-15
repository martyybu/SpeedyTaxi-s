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
    public partial class LoginForm : Form
    {
        //MYSQL connection
        static string MYSQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=speedytaxis";
        MySqlConnection databaseConnection = new MySqlConnection(MYSQLConnectionString);

        //Creates the login form
        public LoginForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            passwordBox.PasswordChar = '*';
            this.BackgroundImage = Properties.Resources.taxi;
        }

        //Checks the credentials
        private void CheckCredentials()
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            //If the username or password is emtpy, asks to insert credentials
            if (username == "" || password == "")
            {
                MessageBox.Show("Please insert credentials");
                return;
            }
            //Selects from User where there's this username and password in the database
            String query = "SELECT * FROM User WHERE username = '" + username + "' AND password = '" + password + "'";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                if (myReader.HasRows)
                {
                    //Opens mainform and closes the login form if the credentials are correct
                    this.Hide();
                    MainForm MainForm = new MainForm();
                    MainForm.Closed += (s, args) => this.Close();
                    MainForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.");
                }
                databaseConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Query error: " + e.Message);

            }
        }

        //Login button listener, checks the credentials
        private void LoginButton_Click(object sender, EventArgs e)
        {
            CheckCredentials();
        }
    }
}
