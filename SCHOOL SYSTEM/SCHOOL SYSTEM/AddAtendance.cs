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
    public partial class AddAtendance : Form
    {
        private MySqlConnection connection;
        public AddAtendance()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            Gradeinsert();
            Batchinsert();
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
        private void Batchinsert()
        {
            string query = "SELECT DISTINCT BATCH FROM student_details ;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    combobatch.Items.Add(reader["BATCH"].ToString());
                }
            }
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if both combobatch and comboBoxgrade are selected
            if (combobatch.SelectedIndex >= 0 && comboBoxgrade.SelectedIndex >= 0)
            {
                string selectedBatch = combobatch.SelectedItem.ToString();
                string selectedGrade = comboBoxgrade.SelectedItem.ToString();
                DateTime selectedDate = dateTimePicker1.Value;

                // Build your query to filter based on selected values
                string query = "SELECT S_INDEX FROM student_details WHERE BATCH = @batch;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@batch", selectedBatch);
                   // cmd.Parameters.AddWithValue("@grade", selectedGrade);
                    connection.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxindex.Items.Add(reader["S_INDEX"].ToString());
                        }
                    }
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Please select both batch and grade before retrieving data.");
            }
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            // Check if a student is selected in comboBoxindex
            if (comboBoxindex.SelectedIndex >= 0)
            {
                string selectedGrade = comboBoxgrade.SelectedItem.ToString();
                int selectedStudentID = Convert.ToInt32(comboBoxindex.SelectedItem.ToString());
                DateTime selectedDate = dateTimePicker1.Value;
                string selectedP_A = radioButtonPresent.Checked ? "P" : "A";

                // Build the INSERT query for the "attendance_of_student" table
                string query = "INSERT INTO attendancy_of_student (grades, student_ID, dates, P_or_A) VALUES (@grade, @student_id, @date, @p_a);";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@grade", selectedGrade);
                    cmd.Parameters.AddWithValue("@student_id", selectedStudentID);
                    cmd.Parameters.AddWithValue("@date", selectedDate);
                    cmd.Parameters.AddWithValue("@p_a", selectedP_A);

                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Attendance added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add attendance.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student from comboBoxindex before adding attendance.");
            }
        }
    }
}
