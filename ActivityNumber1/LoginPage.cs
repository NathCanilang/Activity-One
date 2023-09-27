using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM mbuserinfo";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            string usernameInput = usernameComboBox.Text;
            string passwordInput = PasswordEncrypter.hashPassword(passwordTextBox.Text);
            bool accountActive = false;

            string selectQuery = $"SELECT HashedPassword, Status FROM mbuserinfo WHERE Username = '{usernameInput}'";
            MySqlCommand cmdDataBase = new MySqlCommand(selectQuery, conn);
            MySqlDataReader myReader;

            string enteredUsername = usernameComboBox.Text;
            string enteredPassword = passwordTextBox.Text;

            if (enteredUsername == adminUsername && enteredPassword == adminPassword)
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
            else if (string.IsNullOrWhiteSpace(enteredUsername) || string.IsNullOrWhiteSpace(enteredPassword))
            {
                MessageBox.Show("Please fill in all required fields.", " Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rememberCheckBox.CheckState = CheckState.Unchecked;
                errorAttempts();
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
        private void accountChecker()
        {

        }

        private void textboxCleaner()
        {
            passwordTextBox.Clear();
            usernameComboBox.ResetText();
            rememberCheckBox.CheckState = CheckState.Unchecked;
        }
    }
}
