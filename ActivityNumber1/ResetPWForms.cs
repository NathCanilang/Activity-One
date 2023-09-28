using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;




namespace ActivityNumber1
{
    public partial class ResetPWForms : Form
    {
        public static ResetPWForms ResetPWFormsInstance;

        public ResetPWForms()
        {
            InitializeComponent();
            ResetPWFormsInstance = this;
        }

        private static readonly Random random = new Random();
        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string HashPassword(string password, string salt = null)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] saltBytes = Encoding.Default.GetBytes(salt ?? "");
                byte[] passwordBytes = Encoding.Default.GetBytes(password + Encoding.Default.GetString(saltBytes));
                byte[] hashedPasswordBytes = sha.ComputeHash(passwordBytes);
                return Convert.ToBase64String(hashedPasswordBytes);
            }
        }
        private void Changebtn_Click(object sender, EventArgs e)
        {
            string enteredPassword = passwordtextBox.Text;
            if (string.IsNullOrWhiteSpace(enteredPassword))
            {
                MessageBox.Show("Please fill in all required fields.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // Retrieve the username and email from RecoveryForms
                string enteredUsername = RecoveryForms.RecoveryFormsInstance.usernameTextBoxRF.Text;
                string enteredEmail = RecoveryForms.RecoveryFormsInstance.emailTextBoxRF.Text;
                string newPassword = passwordtextBox.Text;

                // Establish a MySQL connection
                string connectionString = "server=localhost;user=root;database=tubshashsalt;password=";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create a MySQL query to select the specific row in the database
                        string updatePasswordQuery = "UPDATE mbuserinfo SET HashedPassword = @HashedPassword, FixedSaltedPassword = @FixedSaltedPassword, RandomString = @RandomString, RandomSaltedPassword = @RandomSaltedPassword WHERE Username = @Username AND Email = @Email";

                        MySqlCommand cmd = new MySqlCommand(updatePasswordQuery, connection);
                        //Hash
                        string hashedNewPassword = HashPassword(newPassword);
                        cmd.Parameters.AddWithValue("@HashedPassword", hashedNewPassword);
                        //Fixed Salt
                        string asin = "Security";
                        string fixedSaltedPassword = HashPassword(newPassword, asin);
                        cmd.Parameters.AddWithValue("@FixedSaltedPassword", fixedSaltedPassword);
                        //Random String
                        string randomAsin = GenerateRandomString(8);
                        cmd.Parameters.AddWithValue("@RandomString", randomAsin);
                        //Random Salt
                        string randomSaltedPassword = HashPassword(newPassword, randomAsin);
                        cmd.Parameters.AddWithValue("@RandomSaltedPassword", randomSaltedPassword);

                        cmd.Parameters.AddWithValue("@Username", enteredUsername);
                        cmd.Parameters.AddWithValue("@Email", enteredEmail);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Show a confirmation message
                            DialogResult confirmationResult = MessageBox.Show("Your password has been successfully reset.", "PASSWORD RESET", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (confirmationResult == DialogResult.OK)
                            {
                                // Close the ResetPWForms
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password reset failed.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }


        private void ResetPWForms_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
