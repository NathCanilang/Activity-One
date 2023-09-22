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
    public partial class RecoveryForms : Form
    {
        public RecoveryForms()
        {
            InitializeComponent();
        }

        private void RecoveryForms_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            string enteredUsername = usernameTextBoxRF.Text;
            string enteredEmail = emailTextBoxRF.Text;
            
           StoredAccountsForms.storedAccountsInstance.CheckCredentials(enteredUsername, enteredEmail);

            usernameTextBoxRF.Clear();
            emailTextBoxRF.Clear();
        }
    }
}
