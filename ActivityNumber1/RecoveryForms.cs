using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ActivityNumber1
{
    public partial class RecoveryForms : Form
    {
        public static RecoveryForms RecoveryFormsInstance;
        ResetPWForms resetPWForms = new ResetPWForms();

        
        public RecoveryForms()
        {
            InitializeComponent();
            RecoveryFormsInstance = this;

        }    

        private void RecoveryForms_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            usernameTextBoxRF.Clear();
            emailTextBoxRF.Clear();
        }

        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            string enteredUsername = usernameTextBoxRF.Text;
            string enteredEmail = emailTextBoxRF.Text;

            if (string.IsNullOrWhiteSpace(enteredUsername) || string.IsNullOrWhiteSpace(enteredEmail))
            {
                MessageBox.Show("Please fill in all required fields.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Establish a MySQL connection
                string connectionString = "server=localhost;user=root;database=tubshashsalt;password=";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Query the database to check if the username and email match an active account
                        string checkUserEmailQuery = "SELECT Username FROM mbuserinfo WHERE Username = @Username AND Email = @Email AND Status = 'ACTIVE'";
                        MySqlCommand checkUserEmailCommand = new MySqlCommand(checkUserEmailQuery, connection);
                        checkUserEmailCommand.Parameters.AddWithValue("@Username", enteredUsername);
                        checkUserEmailCommand.Parameters.AddWithValue("@Email", enteredEmail);

                        object result = checkUserEmailCommand.ExecuteScalar();

                        if (result != null)
                        {
                            MessageBox.Show("You can now proceed with resetting your password.", "CONGRATULATIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.WindowState = FormWindowState.Minimized;
                            resetPWForms.ShowDialog();
                            this.WindowState = FormWindowState.Normal;
                        }
                        else
                        {
                            MessageBox.Show("Username and/or email not found.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            usernameTextBoxRF.Clear();
            emailTextBoxRF.Clear();
        }

        private void emailLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
