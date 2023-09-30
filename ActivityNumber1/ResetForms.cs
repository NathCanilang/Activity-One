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

namespace ActivityNumber1
{
    public partial class ResetForms : Form
    {
        public static ResetForms ResetFormsInstance;
        public ResetForms()
        {
            InitializeComponent();
            ResetFormsInstance = this;
        }

        private void Changebtn_Click(object sender, EventArgs e)
        {
            string enteredPassword = passwordtextBox.Text;
            string enteredNewPassword = newpasstextBox.Text;
            string fixedSalt = "xCv12dFqwS";
            string randomSalt = PasswordEncrypter.generateSalt();

            if (string.IsNullOrWhiteSpace(enteredPassword) || string.IsNullOrWhiteSpace(enteredNewPassword))
            {
                MessageBox.Show("Please fill in all required fields.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if  ((enteredPassword != enteredNewPassword))
            {
                MessageBox.Show("Passwords do not match.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string enteredUsername = RecoveryForms.RecoveryFormsInstance.usernameTextBoxRF.Text;
                string enteredEmail = RecoveryForms.RecoveryFormsInstance.emailTextBoxRF.Text;
                string newPassword = passwordtextBox.Text;

                string connectionString = "server=localhost;user=root;database=moonbasedatabase;password=";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string updatePasswordQuery = "UPDATE mbuserinfo SET HashedPassword = @HashedPassword, FixedSaltedPassword = @FixedSaltedPassword, RandomString = @RandomString, RandomSaltedPassword = @RandomSaltedPassword WHERE Username = @Username AND Email = @Email";

                        MySqlCommand cmd = new MySqlCommand(updatePasswordQuery, connection);
                        string hashedNewPassword = PasswordEncrypter.hashPassword(newPassword);
                        cmd.Parameters.AddWithValue("@HashedPassword", hashedNewPassword);

                        string fixedSaltedPassword = PasswordEncrypter.fixedSaltPassword(newPassword, fixedSalt);
                        cmd.Parameters.AddWithValue("@FixedSaltedPassword", fixedSaltedPassword);


                        string randomAsin = randomSalt;
                        cmd.Parameters.AddWithValue("@RandomString", randomAsin);

                        string randomSaltedPassword = PasswordEncrypter.randomSaltPassword(newPassword, randomSalt);
                        cmd.Parameters.AddWithValue("@RandomSaltedPassword", randomSaltedPassword);

                        cmd.Parameters.AddWithValue("@Username", enteredUsername);
                        cmd.Parameters.AddWithValue("@Email", enteredEmail);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            DialogResult confirmationResult = MessageBox.Show("Your password has been successfully reset.", "PASSWORD RESET", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (confirmationResult == DialogResult.OK)
                            {
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
            passwordtextBox.Clear();
            newpasstextBox.Clear();
        }

        private void ResetForms_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }


        private void showBtn_Click(object sender, EventArgs e)
        {
            if (closeBtn.Visible == false)
            {
                showBtn.Visible = false;
                closeBtn.Visible = true;
                passwordtextBox.PasswordChar = '\0';
            }

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (showBtn.Visible == false)
            {
                closeBtn.Visible = false;
                showBtn.Visible = true;
                passwordtextBox.PasswordChar = '*';
            }
        }

        private void showBtn1_Click(object sender, EventArgs e)
        {
            if (closeBtn1.Visible == false)
            {
                showBtn1.Visible = false;
                closeBtn1.Visible = true;
                newpasstextBox.PasswordChar = '\0';
            }
        }

        private void closeBtn1_Click(object sender, EventArgs e)
        {
            if (showBtn1.Visible == false)
            {
                closeBtn1.Visible = false;
                showBtn1.Visible = true;
                newpasstextBox.PasswordChar = '*';
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://nordpass.com/most-common-passwords-list/"; 
            System.Diagnostics.Process.Start(url);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://haveibeenpwned.com/";
            System.Diagnostics.Process.Start(url);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            passwordtextBox.Clear();
            newpasstextBox.Clear();
        }
        private void newpasstextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
