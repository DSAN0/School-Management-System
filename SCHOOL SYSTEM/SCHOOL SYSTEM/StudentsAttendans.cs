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
    public partial class StudentsAttendans : Form
    {
        private MySqlConnection connection;
        public StudentsAttendans()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            FillComboBoxGrade();
            FillComboBoxDate();
        }
        private void InitializeDatabaseConnection()
        {
            ConnectionDB conet = new ConnectionDB();
            connection = conet.ConnectDB();
        }

        private void FillComboBoxGrade()
        {
            // Clear any existing items in comboBoxgrade
            comboBoxgrade.Items.Clear();

            string query = "SELECT DISTINCT grades FROM attendancy_of_student;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBoxgrade.Items.Add(reader["grades"].ToString());
                }
            }
            connection.Close();
        }

        private void FillComboBoxDate()
        {
            // Clear any existing items in comboBoxindex
            comboBoxdate.Items.Clear();

            string query = "SELECT DISTINCT dates FROM attendancy_of_student;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    comboBoxdate.Items.Add(reader["dates"].ToString());
                }
            }
            connection.Close();
        }

        private void buttonViwe_Click(object sender, EventArgs e)
        {
              string selectedGrade = comboBoxgrade.SelectedItem?.ToString();
              string selectedDate = comboBoxdate.SelectedItem?.ToString();

              if (string.IsNullOrEmpty(selectedGrade) || string.IsNullOrEmpty(selectedDate))
              {
                  MessageBox.Show("Please select both grade and date.");
                  return;
              }

              // Query to count "P" values
              string countPQuery = "SELECT COUNT(*) FROM attendancy_of_student WHERE grades = @grade AND dates = @date AND P_or_A = 'P';";

              // Query to count "A" values
              string countAQuery = "SELECT COUNT(*) FROM attendancy_of_student WHERE grades = @grade AND dates = @date AND P_or_A = 'A';";

              try
              {
                  using (MySqlCommand cmdP = new MySqlCommand(countPQuery, connection))
                  using (MySqlCommand cmdA = new MySqlCommand(countAQuery, connection))
                  {
                      cmdP.Parameters.AddWithValue("@grade", selectedGrade);
                      cmdP.Parameters.AddWithValue("@date", selectedDate);

                      cmdA.Parameters.AddWithValue("@grade", selectedGrade);
                      cmdA.Parameters.AddWithValue("@date", selectedDate);

                      connection.Open();
                      int countP = Convert.ToInt32(cmdP.ExecuteScalar());
                      int countA = Convert.ToInt32(cmdA.ExecuteScalar());
                      connection.Close();

                      // Update the text boxes with the counts
                      textBoxPresent.Text = countP.ToString();
                      textBoxabsent.Text = countA.ToString();
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("An error occurred: " + ex.Message);
              }



        }
    }
}
