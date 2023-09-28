using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ActivityNumber1
{
    public partial class CreateForms : Form
    {

        public delegate void UserAccountCreatedHandler();
        public static event UserAccountCreatedHandler UserAccountCreated;
        public static CreateForms CreateFormsInstance;        
        private string[] genders = { "Male", "Female"};

        public CreateForms()
        {
            InitializeComponent();                        
            CreateFormsInstance = this;

            string mysqlcon = "server=localhost;user=root;database=moonbasedatabase;password=";
            conn = new MySqlConnection(mysqlcon);
            genderComboBox.Items.AddRange(genders);
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            label1.Parent = createFormsBackPic;
            ageLbl.Parent = createFormsBackPic;
            genderLbl.Parent = createFormsBackPic;
            usernameLbl.Parent = createFormsBackPic;
            passwordLbl.Parent = createFormsBackPic;
            emailLbl.Parent = createFormsBackPic;
            showPasswordCF.Parent = createFormsBackPic;
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

        private void createBtnCF_Click(object sender, EventArgs e)
        {
            // Retrieve values from input fields
            string name = nameTextBoxCF.Text;
            int age;
            string gender = genderComboBox.SelectedItem?.ToString();
            string username = usernameTextBoxCF.Text;
            string password = passwordTextBoxCF.Text;
            string email = emailTextBoxCF.Text;


            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(gender) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in all credentials.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!int.TryParse(ageTextBoxCF.Text, out age) || age <= 0)
            {
                
            }
            else if (InsertDataIntoDatabase(name, age, gender, username, password, email))
            {
                MessageBox.Show("Data inserted successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nameTextBoxCF.Clear();
                ageTextBoxCF.Clear();
                usernameTextBoxCF.Clear();
                passwordTextBoxCF.Clear();
                emailTextBoxCF.Clear();
                genderComboBox.SelectedItem = null;
                return;
            }
            else
            {
                MessageBox.Show("Failed to insert data.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        private bool InsertDataIntoDatabase(string name, int age, string gender, string username, string password, string email)
        {
            string mysqlstr = "server=localhost;user=root;database=tubshashsalt;password=";

            string insertQuery = "INSERT INTO mbuserinfo (FullName, Age, Gender, Username,  Email, HashedPassword, FixedSaltedPassword, RandomString, RandomSaltedPassword) " +
                                 "VALUES (@FullName, @Age, @Gender, @Username, @Email, @HashedPassword, @FixedSaltedPassword, @RandomString, @RandomSaltedPassword )";

            using (MySqlConnection connection = new MySqlConnection(mysqlstr))
            {
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@FullName", name);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);

                    // Hash 
                    string hashedPassword = HashPassword(password);
                    cmd.Parameters.AddWithValue("@HashedPassword", hashedPassword);
                    //Fixed Salt
                    string asin = "Security";
                    string fixedSaltedPassword = HashPassword(password, asin);
                    cmd.Parameters.AddWithValue("@FixedSaltedPassword", fixedSaltedPassword);
                    //Random String
                    string randomAsin = GenerateRandomString(8);
                    cmd.Parameters.AddWithValue("@RandomString", randomAsin);
                    //Random Salt
                    string randomSaltedPassword = HashPassword(password, randomAsin);
                    cmd.Parameters.AddWithValue("@RandomSaltedPassword", randomSaltedPassword);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Data inserted successfully, raise the event.
                            UserAccountCreated?.Invoke();
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert data.");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                        return false;
                    }
                }
            }
        }

        private void CreateForms_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

        }

        private void backBtnCF_Click(object sender, EventArgs e)
        {
            nameTextBoxCF.Clear();
            ageTextBoxCF.Clear();
            usernameTextBoxCF.Clear();
            passwordTextBoxCF.Clear();
            emailTextBoxCF.Clear();
            genderComboBox.SelectedItem = null;
            this.Hide();
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genderComboBox.SelectedItem != null)
            {
                genderComboBox.Text = genderComboBox.SelectedItem.ToString();
            }
        }

        private void showPasswordCF_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCF.Checked)
            {

                passwordTextBoxCF.PasswordChar = '\0';
            }
            else

                if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    throw new Exception("Inputted character is not allowed");
                }
            } 
            catch (Exception b)

            {
                passwordTextBoxCF.PasswordChar = '*';
            }
            
        }
        private void nameTextBoxCF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != ',' && e.KeyChar != '.')
            {
                // Cancel the key press event
                e.Handled = true;
                MessageBox.Show("Name must contain alphabetic characters only.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                // Handle Enter key press (optional)
                e.Handled = true; // You can remove this line if you want to allow Enter key press
            }
        }

 
        private void createBtnCF_Click(object sender, EventArgs e)
        {
            string adminUsername = "Admin";
            string fixedSalt = "xCv12dFqwS";
            string randomSalt = PasswordEncrypter.generateSalt();


            if (string.IsNullOrWhiteSpace(nameTextBoxCF.Text) || string.IsNullOrWhiteSpace(ageTextBoxCF.Text) || string.IsNullOrWhiteSpace(usernameTextBoxCF.Text)
                || string.IsNullOrWhiteSpace(passwordTextBoxCF.Text) || string.IsNullOrWhiteSpace(emailTextBoxCF.Text) || genderComboBox.SelectedItem == null)
 
            {
       
                MessageBox.Show("Please fill out all the required data", "Missing Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                genderComboBox.SelectedItem = null;
                return;
            }


            if (usernameTextBoxCF.Text == adminUsername)
            {
                MessageBox.Show("The entered username is not allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                string insertQuery = "INSERT INTO mbuserinfo (FullName, Age, Gender, Username, Email, HashedPassword, FixedSaltedPassword, RandomString, RandomSaltedPassword) " +
                    "values('" + this.nameTextBoxCF.Text + "', '" + this.ageTextBoxCF.Text + "', '" + this.genderComboBox.SelectedItem.ToString() + "', '" + this.usernameTextBoxCF.Text + "', '" + this.emailTextBoxCF.Text + "', '" + PasswordEncrypter.hashPassword(passwordTextBoxCF.Text) + "', " +
                    "'" + PasswordEncrypter.fixedSaltPassword(passwordTextBoxCF.Text, fixedSalt) + "', '" + randomSalt + "','" + PasswordEncrypter.randomSaltPassword(passwordTextBoxCF.Text, randomSalt) + "')";
                MySqlCommand cmdDataBase = new MySqlCommand(insertQuery, conn);

                try
                {
                    conn.Open();
                    cmdDataBase.ExecuteNonQuery();
                    MessageBox.Show("Account Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    nameTextBoxCF.Clear();
                    ageTextBoxCF.Clear();
                    usernameTextBoxCF.Clear();
                    passwordTextBoxCF.Clear();
                    emailTextBoxCF.Clear();
                    genderComboBox.SelectedItem = null;
                }

                catch (MySqlException a)
                {
                    if (a.Number == 1062)
                    {
                        MessageBox.Show("Username already exist.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("An error occured", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void showPasswordCF_CheckedChanged(object sender, EventArgs e)
        {

            if (showPasswordCF.Checked)
            {
                passwordTextBoxCF.PasswordChar = '\0';
            }
            else
            {
                passwordTextBoxCF.PasswordChar = '*';
            } 

        }
    }
}
