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

namespace SCHOOL_SYSTEM
{
    public partial class RemovePasteYear : Form
    {
        private MySqlConnection connection;
        public RemovePasteYear()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }
        private void InitializeDatabaseConnection()
        {
            ConnectionDB conet = new ConnectionDB();
            connection = conet.ConnectDB();
        }

        private void buttonRemoveAtendence_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Query to delete all data from the "attendancy_of_student" table
                string deleteQuery = "DELETE FROM attendancy_of_student;";

                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("All attendance data removed successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No records were removed from attendance.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonRemoveHomeWork_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Query to delete all data from the "home_work" table
                string deleteQuery = "DELETE FROM home_work;";

                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("All homework data removed successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No records were removed from homework.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
