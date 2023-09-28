using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ActivityNumber1
{
    public partial class LoginPage : Form
    {
        private System.Windows.Forms.Timer loginBtnTimer;

        public static LoginPage loginPageInstance;
        CreateForms createforms = new CreateForms();
        TableForms tableforms = new TableForms();
        RecoveryForms recoveryForms = new RecoveryForms();
        WelcomeForms welcomeForms = new WelcomeForms(); 
        ResetPWForms resetPWForms = new ResetPWForms();

        public int loginAttempts = 0;
        public int currentAttempts = 3;
        
        private string adminUsername = "Admin";
        private string adminPassword = "admin123";

        private bool cooldownActive = false;

        private MySqlConnection conn;

        public LoginPage()
        {
            InitializeComponent();
            loginPageInstance = this;

            loginBtnTimer = new System.Windows.Forms.Timer();
            loginBtnTimer.Interval = 10000;
            loginBtnTimer.Tick += LoginBtnTimer_Tick;

            string mysqlcon = "server=localhost;user=root;database=moonbasedatabase;password=";
            conn = new MySqlConnection(mysqlcon);

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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string usernameInput = usernameComboBox.Text;
            string passwordInput = PasswordEncrypter.hashPassword(passwordTextBox.Text);
            bool accountActive = false;

            string selectQuery = $"SELECT HashedPassword, Status FROM mbuserinfo WHERE Username = '{usernameInput}'";
            MySqlCommand cmdDataBase = new MySqlCommand(selectQuery, conn);
            MySqlDataReader myReader;

            string enteredUsername = usernameComboBox.Text;
            string enteredPassword = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(enteredUsername) || string.IsNullOrWhiteSpace(enteredPassword))
            {
                MessageBox.Show("Please fill in all required fields.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordTextBox.Clear();
                usernameComboBox.ResetText();
                rememberCheckBox.CheckState = CheckState.Unchecked;
                errorAttempts();
                return;
            }
            else if (enteredUsername == adminUsername && enteredPassword == adminPassword)
            {
                loginAttempts = 0;
                currentAttempts = 3;
                MessageBox.Show("Hi Admin, Welcome!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.WindowState = FormWindowState.Minimized;
                tableforms.ShowDialog();
                this.WindowState = FormWindowState.Normal;
                rememberAccount();
                textboxCleaner();

                rememberCheckBox.CheckState = CheckState.Unchecked;
                return;
            }
            else
            {

                try
                {
                    conn.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    if (myReader.Read())
                    {
                        string databasePassword = myReader["HashedPassword"].ToString();
                        string accountStatus = myReader["Status"].ToString();

                        if(accountStatus == "ACTIVATED")
                        {
                            accountActive = true;
                        }

                        if (!accountActive)
                        {
                            MessageBox.Show("Wait for the admin to approve your account!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rememberAccount();
                        }
                        else
                        {
                            if (passwordInput != databasePassword)
                            {
                                MessageBox.Show($"Invalid Password", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                rememberAccount();
                                this.WindowState = FormWindowState.Minimized;
                                welcomeForms.ShowDialog();
                                this.WindowState = FormWindowState.Normal;
                                loginAttempts = 0;

                                currentAttempts = 3;

                                textboxCleaner();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Invalid Username", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorAttempts();
                        textboxCleaner();
                    }
                }

                catch (Exception b)
                {
                    MessageBox.Show(b.Message);
                }

                finally
                {
                    conn.Close();
                }
            }
        }


        public void errorAttempts()
        {     

            if (currentAttempts > 0)
            {
                currentAttempts--;
                MessageBox.Show($"{currentAttempts} {(currentAttempts > 1 ? "attempts" : "attempts")} remaining", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            loginAttempts++;


            if (loginAttempts == 3)
            {
                loginBtn.Enabled = false;
                startTimer();
            }

            if (currentAttempts <= 0)
            {
                currentAttempts = 3;
            }
        }
        public void startTimer()
        {
            cooldownActive = true;
            loginBtnTimer.Start();

        }
        private void LoginBtnTimer_Tick(object sender, EventArgs e)
        {
            cooldownActive = false;
            loginBtnTimer.Stop();
            loginBtn.Enabled = true;
            loginAttempts = 0;
            MessageBox.Show("Cooldown period ended. You can try again now.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if (closeBtn.Visible == false)
            {
                showBtn.Visible = false;
                closeBtn.Visible = true;
                passwordTextBox.PasswordChar = '\0';
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (showBtn.Visible == false)
            {
                closeBtn.Visible = false;
                showBtn.Visible = true;
                passwordTextBox.PasswordChar = '*';
            }
        }
        private void rememberAccount()
        {
            string newItem = usernameComboBox.Text.Trim();
            bool itemExists = usernameComboBox.Items.Contains(newItem);
            if (rememberCheckBox.Checked == true && !itemExists)
            {
                usernameComboBox.Items.Add(newItem);
                usernameComboBox.SelectedIndex = usernameComboBox.Items.IndexOf(newItem);
                usernameComboBox.Text = "";
            }
        }


        private void textboxCleaner()
        {
            passwordTextBox.Clear();
            usernameComboBox.ResetText();
            rememberCheckBox.CheckState = CheckState.Unchecked;

        }
    }
}
