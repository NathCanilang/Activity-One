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
    public partial class WelcomeForms : Form
    {
        public WelcomeForms()
        {
            InitializeComponent();
            BackLbl.Parent = pictureBox1;
        }

        private void BackLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void WelcomeForms_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
