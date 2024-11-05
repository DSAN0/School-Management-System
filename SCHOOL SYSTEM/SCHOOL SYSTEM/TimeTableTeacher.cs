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
    public partial class TimeTableTeacher : Form
    {
        public TimeTableTeacher()
        {
            InitializeComponent();
            DataInsertComboBoxGrade();
        }

        private void DataInsertComboBoxGrade()
        {
            // Create a MySqlConnection using the ConnectionDB class
            using (MySqlConnection connection = new ConnectionDB().ConnectDB())
            {
                try
                {
                    connection.Open();

                    // Define your SQL query to retrieve SUB_ID values from the subject table
                    string query = "SELECT SUB_ID FROM subject";

                    // Create a MySqlCommand and execute the query
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear the comboBox_grade to avoid duplicates
                            comboBox_subid.Items.Clear();

                            // Iterate through the result set and add SUB_ID values to comboBox_grade
                            while (reader.Read())
                            {
                                int subId = reader.GetInt32("SUB_ID");
                                comboBox_subid.Items.Add(subId.ToString()); // Convert to string if needed
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database access
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }











        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSHOW_Click(object sender, EventArgs e)
        {
            PopulateTextboxes();
        }
        private void PopulateTextboxes()
        {
            if (comboBox_subid.SelectedItem == null)
            {
                MessageBox.Show("Please select a subject (SUB_ID) first.");
                return;
            }

            int selectedSubId = Convert.ToInt32(comboBox_subid.SelectedItem);

            // Define the connection and query for each textbox, then populate them
            PopulateTextbox("M", 1, textBox_M_1, selectedSubId);
            PopulateTextbox("M", 2, textBox_M_2, selectedSubId);
            PopulateTextbox("M", 3, textBox_M_3, selectedSubId);
            PopulateTextbox("M", 4, textBox_M_4, selectedSubId);
            PopulateTextbox("M", 5, textBox_M_5, selectedSubId);
            PopulateTextbox("M", 6, textBox_M_6, selectedSubId);
            PopulateTextbox("M", 7, textBox_M_7, selectedSubId);
            PopulateTextbox("M", 8, textBox_M_8, selectedSubId);

            PopulateTextbox("Tu", 1, textBox_Tu_1, selectedSubId);
            PopulateTextbox("Tu", 2, textBox_Tu_2, selectedSubId);
            PopulateTextbox("Tu", 3, textBox_Tu_3, selectedSubId);
            PopulateTextbox("Tu", 4, textBox_Tu_4, selectedSubId);
            PopulateTextbox("Tu", 5, textBox_Tu_5, selectedSubId);
            PopulateTextbox("Tu", 6, textBox_Tu_6, selectedSubId);
            PopulateTextbox("Tu", 7, textBox_Tu_7, selectedSubId);
            PopulateTextbox("Tu", 8, textBox_Tu_8, selectedSubId);

            PopulateTextbox("W", 1, textBox_W_1, selectedSubId);
            PopulateTextbox("W", 2, textBox_W_2, selectedSubId);
            PopulateTextbox("W", 3, textBox_W_3, selectedSubId);
            PopulateTextbox("W", 4, textBox_W_4, selectedSubId);
            PopulateTextbox("W", 5, textBox_W_5, selectedSubId);
            PopulateTextbox("W", 6, textBox_W_6, selectedSubId);
            PopulateTextbox("W", 7, textBox_W_7, selectedSubId);
            PopulateTextbox("W", 8, textBox_W_8, selectedSubId);

            PopulateTextbox("Th", 1, textBox_Th_1, selectedSubId);
            PopulateTextbox("Th", 2, textBox_Th_2, selectedSubId);
            PopulateTextbox("Th", 3, textBox_Th_3, selectedSubId);
            PopulateTextbox("Th", 4, textBox_Th_4, selectedSubId);
            PopulateTextbox("Th", 5, textBox_Th_5, selectedSubId);
            PopulateTextbox("Th", 6, textBox_Th_6, selectedSubId);
            PopulateTextbox("Th", 7, textBox_Th_7, selectedSubId);
            PopulateTextbox("Th", 8, textBox_Th_8, selectedSubId);

            PopulateTextbox("F", 1, textBox_F_1, selectedSubId);
            PopulateTextbox("F", 2, textBox_F_2, selectedSubId);
            PopulateTextbox("F", 3, textBox_F_3, selectedSubId);
            PopulateTextbox("F", 4, textBox_F_4, selectedSubId);
            PopulateTextbox("F", 5, textBox_F_5, selectedSubId);
            PopulateTextbox("F", 6, textBox_F_6, selectedSubId);
            PopulateTextbox("F", 7, textBox_F_7, selectedSubId);
            PopulateTextbox("F", 8, textBox_F_8, selectedSubId);
            
        }
        private void PopulateTextbox(string day, int period, TextBox textBox, int selectedSubId)
        {
            using (MySqlConnection connection = new ConnectionDB().ConnectDB())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT GRADE FROM time_table WHERE SUB_ID = @subId AND DAYTE = @day AND PERIOD = @period";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@subId", selectedSubId);
                        cmd.Parameters.AddWithValue("@day", day);
                        cmd.Parameters.AddWithValue("@period", period);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            textBox.Text = result.ToString();
                        }
                        else
                        {
                            textBox.Text = "No data found";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
