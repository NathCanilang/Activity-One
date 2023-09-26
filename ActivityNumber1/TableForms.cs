using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ActivityNumber1
{
    public partial class TableForms : Form
    {
        public static TableForms TableFormsInstance;
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
            if(dataGridView1.SelectedRows.Count > 0)
            {
                string query = "SELECT * FROM mbuserinfo";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string accountUsername = selectedRow.Cells["Username"].Value.ToString();
                string updateQuery = $"UPDATE mbuserinfo SET Status = 'ACTIVATED' WHERE Username = '{accountUsername}'";
                adapter.Fill(dataTable);
                MySqlCommand cmdDataBase = new MySqlCommand(updateQuery, conn);

                try
                {
                    conn.Open();
                    cmdDataBase.ExecuteNonQuery();
                    MessageBox.Show("Account updated");
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

        private void removeBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM mbuserinfo";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
        }
    }
}