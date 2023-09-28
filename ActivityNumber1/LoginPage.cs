using MySql.Data.MySqlClient;
using System;
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

        public int loginAttempts = 0;
        public int currentAttempts = 3;
        
        private string adminUsername = "Admin";
        private string adminPassword = "admin123";

        private bool cooldownActive = false;

        public LoginPage()
        {
            InitializeComponent();
            loginPageInstance = this;

            loginBtnTimer = new System.Windows.Forms.Timer();
            loginBtnTimer.Interval = 10000;
            loginBtnTimer.Tick += LoginBtnTimer_Tick;

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
            string enteredUsername = usernameComboBox.Text;
            string enteredPassword = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(enteredUsername) || string.IsNullOrWhiteSpace(enteredPassword))
            {
                MessageBox.Show("Please fill in all required fields.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                passwordTextBox.Clear();
                usernameComboBox.ResetText();
                rememberCheckBox.CheckState = CheckState.Unchecked;
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

                        // Query the database to retrieve the hashed password and account status for the entered username
                        string getPasswordQuery = "SELECT HashedPassword, Status FROM mbuserinfo WHERE Username = @Username";
                        MySqlCommand getPasswordCommand = new MySqlCommand(getPasswordQuery, connection);
                        getPasswordCommand.Parameters.AddWithValue("@Username", enteredUsername);
                        MySqlDataReader reader = getPasswordCommand.ExecuteReader();

                        if (reader.Read())
                        {
                            string hashedPasswordFromDatabase = reader["HashedPassword"].ToString();
                            string accountStatus = reader["Status"].ToString();

                            if (accountStatus == "ACTIVE")
                            {
                                // Hash the entered password using the same salt (if applicable) and compare it to the database value
                                string hashedEnteredPassword = HashPassword(enteredPassword);

                                if (hashedEnteredPassword == hashedPasswordFromDatabase)
                                {
                                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.WindowState = FormWindowState.Minimized;
                                    welcomeForms.ShowDialog();
                                    this.WindowState = FormWindowState.Normal;
                                    rememberAccount();

                                    // Clear input fields
                                    passwordTextBox.Clear();
                                    usernameComboBox.ResetText();
                                    rememberCheckBox.CheckState = CheckState.Unchecked;

                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect password.", "TRY AGAIN", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                    passwordTextBox.Clear();
                                    usernameComboBox.ResetText();
                                    errorAttempts();
                                }
                            }
                            else if (accountStatus == "INACTIVE")
                            {
                                MessageBox.Show("Account is not activated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                passwordTextBox.Clear();
                                usernameComboBox.ResetText();
                                errorAttempts();
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            passwordTextBox.Clear();
                            usernameComboBox.ResetText();
                            errorAttempts();
                        }

                        reader.Close();
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



        public void errorAttempts()
        {
            currentAttempts--;
            MessageBox.Show($"{currentAttempts} {(currentAttempts > 1 ? "attempts" : "attempts")} remaining", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            loginAttempts++;          

            if (loginAttempts == 3)
            {
                loginBtn.Enabled = false;
                startTimer();
            }

            else if (currentAttempts <= 0)
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
        private void createAccountLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            createforms.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void forgotPasswordLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            recoveryForms.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
