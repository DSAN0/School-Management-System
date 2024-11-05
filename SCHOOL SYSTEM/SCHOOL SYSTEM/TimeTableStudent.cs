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
    public partial class TimeTableStudent : Form
    {
        private TextBox[,] dayPeriodTextBoxes;

        public TimeTableStudent()
        {
            InitializeComponent();
            
            PopulateComboBoxGrade();
            InitializeTextBoxArray();
        }

        private void InitializeTextBoxArray()
        {
            // Create a 2D array of textboxes for days (rows) and periods (columns)
            dayPeriodTextBoxes = new TextBox[5, 8]
            {
                { textBox_M_1, textBox_M_2, textBox_M_3, textBox_M_4, textBox_M_5, textBox_M_6, textBox_M_7, textBox_M_8 },
                { textBox_T_1, textBox_T_2, textBox_T_3, textBox_T_4, textBox_T_5, textBox_T_6, textBox_T_7, textBox_T_8 },
                { textBox_W_1, textBox_W_2, textBox_W_3, textBox_W_4, textBox_W_5, textBox_W_6, textBox_W_7, textBox_W_8 },
                { textBox_Th_1, textBox_Th_2, textBox_Th_3, textBox_Th_4, textBox_Th_5, textBox_Th_6, textBox_Th_7, textBox_Th_8 },
                { textBox_F_1, textBox_F_2, textBox_F_3, textBox_F_4, textBox_F_5, textBox_F_6, textBox_F_7, textBox_F_8 }
            };
        }
        private void PopulateComboBoxGrade()
        {
            // Clear existing items in comboBox_grade
            comboBox_grade.Items.Clear();

            // Define your database connection
            using (MySqlConnection connection = new ConnectionDB().ConnectDB())
            {
                try
                {
                    connection.Open();

                    // Define your SQL query to retrieve GRADE values from the update_grade table
                    string query = "SELECT GRADE FROM update_grade";

                    // Create a MySqlCommand and execute the query
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Iterate through the result set and add GRADE values to comboBox_grade
                            while (reader.Read())
                            {
                                string grade = reader.GetString("GRADE");
                                comboBox_grade.Items.Add(grade);
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
        private void button_SHOW_Click(object sender, EventArgs e)
        {
            PopulateTextboxes();
        }
        private void PopulateTextboxes()
        {
            if (comboBox_grade.SelectedItem == null)
            {
                MessageBox.Show("Please select a grade first.");
                return;
            }

            string selectedGrade = comboBox_grade.SelectedItem.ToString();

            // Loop through days and periods
            for (int dayIndex = 0; dayIndex < 5; dayIndex++)
            {
                for (int periodIndex = 0; periodIndex < 8; periodIndex++)
                {
                    string day = GetDayName(dayIndex);
                    int period = periodIndex + 1;

                    string subjectName = GetSubjectName(selectedGrade, day, period);

                    // Populate the corresponding textbox
                    dayPeriodTextBoxes[dayIndex, periodIndex].Text = subjectName;
                }
            }
        }
        private string GetSubjectName(string grade, string day, int period)
        {
            using (MySqlConnection connection = new ConnectionDB().ConnectDB())
            {
                try
                {
                    connection.Open();

                    // First, retrieve the SUB_ID from the time_table
                    string subIdQuery = @"
                SELECT SUB_ID
                FROM time_table
                WHERE GRADE = @grade
                AND DAYTE = @day
                AND PERIOD = @period";

                    using (MySqlCommand subIdCmd = new MySqlCommand(subIdQuery, connection))
                    {
                        subIdCmd.Parameters.AddWithValue("@grade", grade);
                        subIdCmd.Parameters.AddWithValue("@day", day);
                        subIdCmd.Parameters.AddWithValue("@period", period);

                        object subIdResult = subIdCmd.ExecuteScalar();

                        if (subIdResult != null)
                        {
                            int subId = Convert.ToInt32(subIdResult);

                            // Now, retrieve the SUBJECT_NAME using the retrieved SUB_ID
                            string subjectNameQuery = "SELECT SUBJECT_NAME FROM subject WHERE SUB_ID = @subId";

                            using (MySqlCommand cmd = new MySqlCommand(subjectNameQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@subId", subId);

                                object result = cmd.ExecuteScalar();

                                return result != null ? result.ToString() : null;
                            }
                        }
                        else
                        {
                            return "No data found";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }
        private string GetDayName(int dayIndex)
        {
            switch (dayIndex)
            {
                case 0: return "M";
                case 1: return "Tu";
                case 2: return "W";
                case 3: return "Th";
                case 4: return "F";
                default: return "";
            }
        }

    }
}
