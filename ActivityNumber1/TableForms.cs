
﻿using MySql.Data.MySqlClient;
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
                string query = "SELECT * FROM mbuserinfo";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string accountUsername = selectedRow.Cells["Username"].Value.ToString();
                string updateQuery = $"UPDATE mbuserinfo SET Status = 'ACTIVATED' WHERE Username = '{accountUsername}'";
                MySqlCommand cmdDataBase = new MySqlCommand(updateQuery, conn);

                try
                {
                    conn.Open();
                    cmdDataBase.ExecuteNonQuery();
                    selectedRow.Cells["Status"].Value = "ACTIVATED";
                    MessageBox.Show("Account updated!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string query = "SELECT * FROM mbuserinfo";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string accountUsername = selectedRow.Cells["Username"].Value.ToString();
            string updateQuery = $"DELETE FROM mbuserinfo WHERE Username = '{accountUsername}'";
            MySqlCommand cmdDataBase = new MySqlCommand(updateQuery, conn);

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

        public void LoadUserData()
        {
            string mysqlstr = "server=localhost;user=root;database=tubshashsalt;password=";
            // SQL query to retrieve data from the mbuserinfo table, excluding password-related columns.
            string query = "SELECT FullName, Age, Gender, Username, Email, Status FROM mbuserinfo";

            using (MySqlConnection connection = new MySqlConnection(mysqlstr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add a row to the DataGridView for each user.
                                userAccountsTable.Rows.Add(
                                    reader["FullName"].ToString(),
                                    reader["Age"].ToString(),
                                    reader["Gender"].ToString(),
                                    reader["Username"].ToString(),
                                    reader["Email"].ToString(),
                                    reader["Status"].ToString()
                                );
                            }
                        }
                        HideColumnIfExists("HashedPassword");
                        HideColumnIfExists("FixedSaltedPassword");
                        HideColumnIfExists("RandomString");
                        HideColumnIfExists("RandomSaltedPassword");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void Escape_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the "Escape" key is pressed.
            if (e.KeyCode == Keys.Escape)
            {
                // Clear the selection in the DataGridView.
                userAccountsTable.ClearSelection();
            }
        }

        
    }
}