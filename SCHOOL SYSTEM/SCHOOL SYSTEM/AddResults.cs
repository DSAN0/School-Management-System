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
    public partial class AddResults : Form
    {
        private MySqlConnection connection;

        public AddResults()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            ComboBoxResult();
            ComboBoxGrade();
            ComboBoxBatch(); 
            ComboBoxSubID(); 

        }
        public void InitializeDatabaseConnection()
        {
            ConnectionDB conet = new ConnectionDB();
            connection = conet.ConnectDB();
        }

        private void ComboBoxResult()
        {
            // Populate comboBoxresult with the result values
            comboBoxresult.Items.Add("A+");
            comboBoxresult.Items.Add("A");
            comboBoxresult.Items.Add("A-");
            comboBoxresult.Items.Add("B+");
            comboBoxresult.Items.Add("B");
            comboBoxresult.Items.Add("B-");
            comboBoxresult.Items.Add("C+");
            comboBoxresult.Items.Add("C");
            comboBoxresult.Items.Add("F");
        }

        private void ComboBoxGrade()
        {
            try
            {
                connection.Open();
                string query = "SELECT DISTINCT GRADE FROM update_grade"; // Replace with your actual table name
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxgrade.Items.Add(reader["GRADE"].ToString());
                }

                reader.Close();
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

        private void ComboBoxBatch()
        {
            try
            {
                connection.Open();
                string query = "SELECT DISTINCT BATCH FROM update_grade"; // Replace with your actual table name and column
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxbatch.Items.Add(reader["BATCH"].ToString());
                }

                reader.Close();
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

        private void ComboBoxSubID()
        {
            try
            {
                connection.Open();
                string query = "SELECT DISTINCT SUB_ID FROM subject"; // Replace with your actual table name and column
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxsubid.Items.Add(reader["SUB_ID"].ToString());
                }

                reader.Close();
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


        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (comboBoxgrade.SelectedItem != null &&
                comboBoxbatch.SelectedItem != null &&
                comboBoxsubid.SelectedItem != null &&
                !string.IsNullOrWhiteSpace(textBoxindex.Text) &&
                !string.IsNullOrWhiteSpace(textBoxexamname.Text) &&
                comboBoxresult.SelectedItem != null)
            {
                if (int.TryParse(textBoxindex.Text, out int index))
                {
                    if (IndexExistsInDatabase(index))
                    {
                        // Insert data into the database using SQL queries
                        try
                        {
                            connection.Open();
                            string query = "INSERT INTO results (GRADE, BATCH, INDEX_NO, SUB_ID, EXAM_NAME, RESULT) " +
                                           "VALUES (@Grade, @Batch, @IndexNo, @SubId, @ExamName, @Result)";
                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("@Grade", comboBoxgrade.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@Batch", comboBoxbatch.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@IndexNo", index);
                            cmd.Parameters.AddWithValue("@SubId", comboBoxsubid.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@ExamName", textBoxexamname.Text);
                            cmd.Parameters.AddWithValue("@Result", comboBoxresult.SelectedItem.ToString());
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Data inserted successfully.");
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
                        MessageBox.Show("Index does not exist in the database.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid index value. Please enter a valid integer.");
                }
            }
            else
            {
                MessageBox.Show("Please enter all data.");
            }
        }
        private bool IndexExistsInDatabase(int index)
        {
            // Implement the logic to check if the index exists in your student_details table
            try
            {
                connection.Open();
                string query = "SELECT S_INDEX FROM student_details WHERE S_INDEX = @Index";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Index", index);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    return reader.Read(); // Returns true if the index is found, false otherwise
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false; // Return false in case of an error
            }
            finally
            {
                connection.Close();
            }
        }


    }
}
