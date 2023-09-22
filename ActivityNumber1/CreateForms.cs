using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ActivityNumber1
{
    public partial class CreateForms : Form
    {
        public static CreateForms CreateFormsInstance;
        bool usernameExist = false;
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
                if (char.IsNumber(e.KeyChar))
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
            if (string.IsNullOrWhiteSpace(nameTextBoxCF.Text) || string.IsNullOrWhiteSpace(ageTextBoxCF.Text) || string.IsNullOrWhiteSpace(usernameTextBoxCF.Text)
                || string.IsNullOrWhiteSpace(passwordTextBoxCF.Text) || string.IsNullOrWhiteSpace(emailTextBoxCF.Text) || genderComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill out all the required data", "Missing Informations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                genderComboBox.SelectedItem = null;
                return;
            }

            else
            {
                DialogResult choices = MessageBox.Show("Are you sure to the information that you have entered?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choices == DialogResult.Yes)
                {
                    if (string.IsNullOrWhiteSpace(nameTextBoxCF.Text) || string.IsNullOrWhiteSpace(ageTextBoxCF.Text) || string.IsNullOrWhiteSpace(usernameTextBoxCF.Text)
                || string.IsNullOrWhiteSpace(passwordTextBoxCF.Text) || string.IsNullOrWhiteSpace(emailTextBoxCF.Text) || genderComboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Please fill out all the required data", "Missing Informations", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        genderComboBox.SelectedItem = null;
                        return;
                    }
                    //
                    if (usernameTextBoxCF.Text.Trim().Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("The username 'Admin' is not allowed.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //
                    usernameExist = false;
                    foreach (DataGridViewRow row in TableForms.TableFormsInstance.userAccountsTable.Rows)
                    {
                        string rowUsername = row.Cells["usernameColumn"].Value?.ToString();
                        if (rowUsername == usernameTextBoxCF.Text)
                        {
                            usernameExist = true;
                            MessageBox.Show("Username Already Exists", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            usernameTextBoxCF.Clear();
                            break;
                        }
                    }
                    if (!usernameExist)
                    {
                        string gmailAttatch = emailTextBoxCF.Text + "@gmail.com";
                        TableForms.TableFormsInstance.addAccount(nameTextBoxCF.Text, ageTextBoxCF.Text, genderComboBox.SelectedItem.ToString(), usernameTextBoxCF.Text, passwordTextBoxCF.Text, gmailAttatch);
                        MessageBox.Show("Account Created, Wait for the admin to approve your account.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        nameTextBoxCF.Clear();
                        ageTextBoxCF.Clear();
                        usernameTextBoxCF.Clear();
                        passwordTextBoxCF.Clear();
                        emailTextBoxCF.Clear();
                        genderComboBox.SelectedItem = null;
                    }
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
