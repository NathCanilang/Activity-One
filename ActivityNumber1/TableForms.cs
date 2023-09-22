using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ActivityNumber1
{
    public partial class TableForms : Form
    {
        public static TableForms TableFormsInstance;
        StoredAccountsForms storedAccountsForms = new StoredAccountsForms();      

        public TableForms()
        {
            InitializeComponent();
            TableFormsInstance = this;
        }

        private void TableForms_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void addAccount(string name, string age, string gender, string username, string password, string email)
        {
               userAccountsTable.Rows.Add(name, age, gender, username, password, email);
        }

        private void approvalBtn_Click(object sender, EventArgs e)
        {
            int rowsSelected = userAccountsTable.SelectedRows.Count;

            if (rowsSelected > 0)
            {
                foreach (DataGridViewRow selectedRow in userAccountsTable.SelectedRows)
                {
     
                    string name = selectedRow.Cells["nameColumn"].Value.ToString();
                    string age = selectedRow.Cells["ageColumn"].Value.ToString();
                    string gender = selectedRow.Cells["genderColumn"].Value.ToString();
                    string username = selectedRow.Cells["usernameColumn"].Value.ToString();
                    string password = selectedRow.Cells["passwordColumn"].Value.ToString();
                    string email = selectedRow.Cells["emailColumn"].Value.ToString();
                  
                    storedAccountsForms.addAccount(name, age, gender, username, password, email);
                    
                    MessageBox.Show("Account Approved", "Approval", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userAccountsTable.Rows.Remove(selectedRow);
                }
            }
            else if (rowsSelected == 0)
            {
                MessageBox.Show("Select a row first", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void storedAccBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            storedAccountsForms.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (userAccountsTable.SelectedRows.Count > 0)
            {
                DialogResult choices = MessageBox.Show("Are you sure to reject this account?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choices == DialogResult.Yes)
                {
                    int selectedIndex = userAccountsTable.SelectedRows[0].Index;
                    userAccountsTable.Rows.RemoveAt(selectedIndex);
                }
            }
            else if (userAccountsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select A Row First", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            /*DialogResult choices = MessageBox.Show("Are you sure to reject this account?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choices == DialogResult.Yes)
            {
                if (userAccountsTable.SelectedRows.Count > 0)
                {
                    int selectedIndex = userAccountsTable.SelectedRows[0].Index;
                    userAccountsTable.Rows.RemoveAt(selectedIndex);

                }
                else if (userAccountsTable.SelectedRows.Count == 0)
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

