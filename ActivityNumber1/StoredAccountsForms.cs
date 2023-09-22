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
    public partial class StoredAccountsForms : Form
    {
        public static StoredAccountsForms storedAccountsInstance;
       
        public StoredAccountsForms()
        {
            InitializeComponent();
            storedAccountsInstance = this;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void StoredAccountsForms_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
        public void addAccount(string name, string age, string gender, string username, string password, string email)
        {
            storedAccTable.Rows.Add(name, age, gender, username, password, email);
        }
        public void CheckCredentials(string savedUsername, string savedEmail)
        {
            bool credentialsFound = false;
            string userPassword = "";

            foreach (DataGridViewRow savedAccount in storedAccTable.Rows)
            {
                string rowUsername = savedAccount.Cells["usernameCol"].Value?.ToString();
                string rowEmail = savedAccount.Cells["emailCol"].Value?.ToString();

                if (rowUsername == savedUsername && rowEmail == savedEmail)
                {
                    credentialsFound = true;
                    userPassword = savedAccount.Cells["passwordCol"].Value.ToString();
                    break;
                }
            }
           if (credentialsFound)
           {
                MessageBox.Show($"Your Password is: " + userPassword, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else
           {
                MessageBox.Show("Invalid credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (storedAccTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select A Row First", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if (storedAccTable.SelectedRows.Count > 0)
            {
                DialogResult choices = MessageBox.Show("Are you sure you want to delete this account?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(choices == DialogResult.Yes)
                {
                    int selectedIndex = storedAccTable.SelectedRows[0].Index;
                    storedAccTable.Rows.RemoveAt(selectedIndex);
                }
            }

            /*DialogResult choices = MessageBox.Show("Are you sure you want to delete this account?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choices == DialogResult.Yes)
            {
                if (storedAccTable.SelectedRows.Count > 0)
                {
                    int selectedIndex = storedAccTable.SelectedRows[0].Index;
                    storedAccTable.Rows.RemoveAt(selectedIndex);
                }
                else if (storedAccTable.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please Select A Row First", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (choices == DialogResult.No)
            {

            }*/
        }
    }
}

