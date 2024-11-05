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
    public partial class BatchPassNewGrade : Form
    {
        private MySqlConnection connection;
        public BatchPassNewGrade()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            Gradeinsert();
        }
        private void InitializeDatabaseConnection()
        {
            ConnectionDB conet = new ConnectionDB();
            connection = conet.ConnectDB();
        }

        private void Gradeinsert()
        {
            string query = "SELECT DISTINCT GRADE FROM update_grade ;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    comboBoxgrade.Items.Add(reader["GRADE"].ToString());
                }
            }
            connection.Close();
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            string selectedGrade = comboBoxgrade.SelectedItem?.ToString();
            int newBatch;

            if (string.IsNullOrEmpty(selectedGrade))
            {
                MessageBox.Show("Please select a grade.");
                return;
            }

            if (!int.TryParse(textBoxBatch.Text, out newBatch))
            {
                MessageBox.Show("Please enter a valid batch value.");
                return;
            }

            try
            {
                connection.Open();

                string updateQuery = "UPDATE update_grade SET BATCH = @newBatch WHERE GRADE = @selectedGrade;";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@newBatch", newBatch);
                    cmd.Parameters.AddWithValue("@selectedGrade", selectedGrade);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Batch updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No records were updated. Make sure the grade exists.");
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
