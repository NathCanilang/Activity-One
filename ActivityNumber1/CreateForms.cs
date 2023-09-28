using System;
using System.Windows.Forms;
using System.Linq;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Text;

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
                MessageBox.Show("Please fill in all credentials.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                return;
            }
            else
            {
                MessageBox.Show("Failed to insert data.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Name must contain alphabetic characters only.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                // Handle Enter key press (optional)
                e.Handled = true; // You can remove this line if you want to allow Enter key press
            }
        }


        private void ageTextBoxCF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancel the key press event
                e.Handled = true;
                MessageBox.Show("Please enter digits only for age.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Convert the current text in the ageTextBox to an integer, assuming it's empty or a valid number
                int currentAge;
                if (int.TryParse(ageTextBoxCF.Text + e.KeyChar, out currentAge))
                {
                    // Check if the age is within the desired range (1-100)
                    if (currentAge < 1 || currentAge > 100)
                    {
                        e.Handled = true;
                        MessageBox.Show("Age must be between 1 and 100.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ageTextBoxCF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
