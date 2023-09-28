using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ActivityNumber1
{
    public partial class TableForms : Form
    {
        public static TableForms TableFormsInstance;     

        public TableForms()
        {
            InitializeComponent();
            TableFormsInstance = this;

            // Define columns for the DataGridView.
            userAccountsTable.Columns.Add("FullName", "Full Name");
            userAccountsTable.Columns.Add("Age", "Age");
            userAccountsTable.Columns.Add("Gender", "Gender");
            userAccountsTable.Columns.Add("Username", "Username");
            userAccountsTable.Columns.Add("Email", "Email");
            userAccountsTable.Columns.Add("Status", "Status");
            // Call a method to load data from the database and populate the DataGridView.
            LoadUserData();

            // Subscribe to the UserAccountCreated event.
            CreateForms.UserAccountCreated += HandleUserAccountCreated;
            userAccountsTable.KeyDown += Escape_KeyDown;
        }

        private void TableForms_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }       

        private void Approvebtn_Click(object sender, EventArgs e)
        {
            if (userAccountsTable.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = userAccountsTable.SelectedRows[0];

                // Get the value from the "Username" column
                string usernameToApprove = selectedRow.Cells["Username"].Value.ToString();

                // Establish a MySQL connection
                string connectionString = "server=localhost;user=root;database=tubshashsalt;password=";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Check the activation status in the database
                        string checkActivationQuery = "SELECT Status FROM mbuserinfo WHERE Username = @Username";
                        MySqlCommand checkActivationCommand = new MySqlCommand(checkActivationQuery, connection);
                        checkActivationCommand.Parameters.AddWithValue("@Username", usernameToApprove);
                        object activationStatusObj = checkActivationCommand.ExecuteScalar();

                        if (activationStatusObj != null && activationStatusObj.ToString() == "ACTIVE")
                        {
                            MessageBox.Show("This account is already activated.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Update the status in the database
                            string updateQuery = "UPDATE mbuserinfo SET Status = @Status WHERE Username = @Username";
                            MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                            updateCommand.Parameters.AddWithValue("@Status", "ACTIVE");
                            updateCommand.Parameters.AddWithValue("@Username", usernameToApprove);

                            // Execute the UPDATE command
                            updateCommand.ExecuteNonQuery();

                            // Update the status in the DataGridView
                            selectedRow.Cells["Status"].Value = "ACTIVE";

                            MessageBox.Show("Account activated successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error activating account: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row first.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (userAccountsTable.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = userAccountsTable.SelectedRows[0];

                    // Get the value from the "Username" column (assuming it's a unique identifier)
                    string usernameToDelete = selectedRow.Cells["Username"].Value.ToString();

                    // Remove the row from the DataGridView
                    userAccountsTable.Rows.Remove(selectedRow);
                    DeleteUserRecordDB(usernameToDelete);
                    
                }
            }
            else
            {
                MessageBox.Show("Please select a row first.", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUserRecordDB(string username)
        {
            // Establish a MySQL connection and delete the record with the specified username
            string connectionString = "server=localhost;user=root;database=tubshashsalt;password=";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a DELETE command
                    string deleteQuery = "DELETE FROM mbuserinfo WHERE Username = @Username";
                    MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);
                    cmd.Parameters.AddWithValue("@Username", username);

                    // Execute the DELETE command
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void HideColumnIfExists(string columnName)
        {
            if (userAccountsTable.Columns.Contains(columnName))
            {
                userAccountsTable.Columns[columnName].Visible = false;
            }
        }

        // Event handler to update the DataGridView when a new user account is created.
        private void HandleUserAccountCreated()
        {
            // Clear the existing data in the DataGridView.
            userAccountsTable.Rows.Clear();
            LoadUserData();
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

