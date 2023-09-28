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
        public static CreateForms CreateFormsInstance;
        private string[] genders = {"Male", "Female"};

        private MySqlConnection conn;
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

        private void nameTextBoxCF_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    throw new Exception ("Inputted character is not allowed");
                }
            } 
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );  
            }
        }

        private void ageTextBoxCF_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
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
                MessageBox.Show(b.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (genderComboBox.SelectedItem != null)
            {
                genderComboBox.Text = genderComboBox.SelectedItem.ToString();
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
                return;
            }

            if (usernameTextBoxCF.Text == adminUsername)
            {
                MessageBox.Show("The entered username is not allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult choices = MessageBox.Show("Are you sure to the information that you have entered?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(choices == DialogResult.Yes)
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
                        usernameTextBoxCF.Clear();
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
