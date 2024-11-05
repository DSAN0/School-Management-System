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
    
    public partial class ExamResultStudent : Form
    {
        private MySqlConnection connection;
        public ExamResultStudent()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            Batchdata();
            Gradedata();
            Indexdata();
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
        private void Indexdata()
        {
            string query = "SELECT DISTINCT INDEX_NO FROM results ;";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {

                while (reader.Read())
                {
                    comboBoxindex.Items.Add(reader["INDEX_NO"].ToString());
                }
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxbatch.SelectedIndex >= 0 && comboBoxgrade.SelectedIndex >= 0 && comboBoxindex.SelectedIndex >= 0)
            {
                string batch = comboBoxbatch.SelectedItem.ToString();
                string grade = comboBoxgrade.SelectedItem.ToString();
                string indexNo = comboBoxindex.SelectedItem.ToString();

                // Construct the SQL query to get Exam Names based on selected values
                string query = "SELECT DISTINCT EXAM_NAME FROM results " +
                               "WHERE BATCH = @batch AND GRADE = @grade AND INDEX_NO = @indexNo";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@batch", batch);
                    cmd.Parameters.AddWithValue("@grade", grade);
                    cmd.Parameters.AddWithValue("@indexNo", indexNo);

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

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (comboBoxExamname.SelectedIndex >= 0)
            {
                string selectedExamName = comboBoxExamname.SelectedItem.ToString();

                // Construct the SQL query to get the result based on selected Exam Name
                string query = "SELECT RESULT FROM results WHERE EXAM_NAME = @examName";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@examName", selectedExamName);

                    try
                    {
                        connection.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            textBoxresult.Text = result.ToString();
                        }
                        else
                        {
                            textBoxresult.Text = "Result not found.";
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
                MessageBox.Show("Please select an exam name.");
            }
        }
    }
}
