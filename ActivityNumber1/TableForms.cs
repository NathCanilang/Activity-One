using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

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
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            refreshTable();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void approvalBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult choices = MessageBox.Show("Activate selected accounts?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (choices == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();

                        foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                        {
                            string accountUsername = selectedRow.Cells["Username"].Value.ToString();
                            string updateQuery = $"UPDATE mbuserinfo SET Status = 'ACTIVATED' WHERE Username = '{accountUsername}'";
                            MySqlCommand cmdDataBase = new MySqlCommand(updateQuery, conn);
                            cmdDataBase.ExecuteNonQuery();
                            selectedRow.Cells["Status"].Value = "ACTIVATED";
                        }

                        MessageBox.Show("Selected accounts updated!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM mbuserinfo";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string accountUsername = selectedRow.Cells["Username"].Value.ToString();
            string updateQuery = $"DELETE FROM mbuserinfo WHERE Username = '{accountUsername}'";
            MySqlCommand cmdDataBase = new MySqlCommand(updateQuery, conn);

            DialogResult choices = MessageBox.Show("Are you sure you want to delete this account?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choices == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    cmdDataBase.ExecuteNonQuery();
                    refreshTable();
                    MessageBox.Show("Account deleted", "Admin Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void refreshTable()
        {
            string mysqlcon = "server=localhost;user=root;database=moonbasedatabase;password=";
            conn = new MySqlConnection(mysqlcon);

            using (conn = new MySqlConnection(mysqlcon))
            {
                string selectQuery = "SELECT * FROM mbuserinfo";
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, conn);
                DataTable dataTable = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}