using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ActivityNumber1
{
    public partial class RecoveryForms : Form
    {
        public static RecoveryForms RecoveryFormsInstance;
        ResetForms resetForms = new ResetForms();
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
            //Tuba
            usernameTextBoxRF.Clear();
            emailTextBoxRF.Clear();

        }

        private void verifyBtn_Click(object sender, EventArgs e)
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
                string connectionString = "server=localhost;user=root;database=moonbasedatabase;password=";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Query the database to check if the username and email match an active account
                        string checkUserEmailQuery = "SELECT Username FROM mbuserinfo WHERE Username = @Username AND Email = @Email AND Status = 'ACTIVATED'";
                        using (MySqlCommand checkUserEmailCommand = new MySqlCommand(checkUserEmailQuery, connection))
                        {
                            checkUserEmailCommand.Parameters.AddWithValue("@Username", enteredUsername);
                            checkUserEmailCommand.Parameters.AddWithValue("@Email", enteredEmail);

                            object result = checkUserEmailCommand.ExecuteScalar();

                            if (result != null)
                            {
                                MessageBox.Show("You can now proceed with resetting your password.", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.WindowState = FormWindowState.Minimized;
                                resetForms.ShowDialog();
                                this.WindowState = FormWindowState.Normal;
                            }
                            else
                            {
                                MessageBox.Show("Username and/or email not found.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
