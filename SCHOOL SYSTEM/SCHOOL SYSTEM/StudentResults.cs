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
    public partial class StudentResults : Form
    {
        private MySqlConnection connection;
        public StudentResults()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            Batchdata();
            Gradedata();
            
        }
        private void InitializeDatabaseConnection()
        {
            ConnectionDB conet = new ConnectionDB();
            connection = conet.ConnectDB();
        }
        private void Batchdata()
        {
            string query = "SELECT DISTINCT BATCH FROM results ;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    comboBoxbatch.Items.Add(reader["BATCH"].ToString());
                }
            }
            connection.Close();

        }
        private void Gradedata()
        {
            string query = "SELECT DISTINCT GRADE FROM results ;";
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

        private void buttonDETAILS_Click(object sender, EventArgs e)
        {
            if (comboBoxbatch.SelectedIndex >= 0 && comboBoxgrade.SelectedIndex >= 0 )
            {
                string batch = comboBoxbatch.SelectedItem.ToString();
                string grade = comboBoxgrade.SelectedItem.ToString();
               

                // Construct the SQL query to get Exam Names based on selected values
                string query = "SELECT DISTINCT EXAM_NAME FROM results " +
                               "WHERE BATCH = @batch AND GRADE = @grade ";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@batch", batch);
                    cmd.Parameters.AddWithValue("@grade", grade);
                   

                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            comboBoxExamname.Items.Clear();
                            while (reader.Read())
                            {
                                comboBoxExamname.Items.Add(reader["EXAM_NAME"].ToString());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select values for batch, grade, and index.");
            }
        }

        private void buttonRESULT_Click(object sender, EventArgs e)
        {
            if (comboBoxbatch.SelectedIndex >= 0 && comboBoxgrade.SelectedIndex >= 0 && comboBoxExamname.SelectedIndex >= 0)
            {
                string batch = comboBoxbatch.SelectedItem.ToString();
                string grade = comboBoxgrade.SelectedItem.ToString();
                string examName = comboBoxExamname.SelectedItem.ToString();

                try
                {
                    connection.Open();

                    // Query to get the total count of results for the selected criteria
                    string totalQuery = "SELECT COUNT(*) AS Total " +
                                        "FROM results " +
                                        "WHERE BATCH = @batch " +
                                        "AND GRADE = @grade " +
                                        "AND EXAM_NAME = @examName;";
                    MySqlCommand totalCmd = new MySqlCommand(totalQuery, connection);
                    totalCmd.Parameters.AddWithValue("@batch", batch);
                    totalCmd.Parameters.AddWithValue("@grade", grade);
                    totalCmd.Parameters.AddWithValue("@examName", examName);

                    int totalCount = Convert.ToInt32(totalCmd.ExecuteScalar());

                    // Query to get the pass count for the selected criteria
                    string passQuery = "SELECT COUNT(*) AS Pass " +
                                       "FROM results " +
                                       "WHERE result != 'F' " +
                                       "AND BATCH = @batch " +
                                       "AND GRADE = @grade " +
                                       "AND EXAM_NAME = @examName;";
                    MySqlCommand passCmd = new MySqlCommand(passQuery, connection);
                    passCmd.Parameters.AddWithValue("@batch", batch);
                    passCmd.Parameters.AddWithValue("@grade", grade);
                    passCmd.Parameters.AddWithValue("@examName", examName);

                    int passCount = Convert.ToInt32(passCmd.ExecuteScalar());

                    int failCount = totalCount - passCount;

                    textBoxpass.Text = ((double)passCount / totalCount * 100).ToString("0.00") + "%";
                    textBoxfail.Text = ((double)failCount / totalCount * 100).ToString("0.00") + "%";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select values for batch, grade, and exam name.");
            }
        }
    }
}
