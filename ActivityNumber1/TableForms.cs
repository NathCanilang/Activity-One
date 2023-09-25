using MySql.Data.MySqlClient;
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
        private MySqlConnection conn;
        

        public TableForms()
        {
            InitializeComponent();
            TableFormsInstance = this;

            string mysqlcon = "server=localhost;user=root;database=moonbasedatabase;password=";
            conn = new MySqlConnection(mysqlcon);

            string query = "SELECT * FROM mbuserinfo";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void TableForms_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void addAccount()
        {
              
        }

        private void approvalBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void storedAccBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            storedAccountsForms.ShowDialog();
            this.WindowState = FormWindowState.Normal;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}

