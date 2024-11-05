using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.X509;

namespace SCHOOL_SYSTEM
{
    public partial class AddTimeTable : Form
    {
        /*  addition of this code 
                       
                      cannot see  same location deffrent grade subject id */
        string grade;
       // int subid;



        public AddTimeTable()
        {
            InitializeComponent();
            InsertDataComboBox();



        }

        private void InsertDataComboBox()
        {
            ConnectionDB connect = new ConnectionDB();
            MySqlConnection connection = connect.ConnectDB(); 



            
                try
                {
                    connection.Open();

                    // Query to retrieve distinct GRADE values that are not in time_table
                    string query = "SELECT update_grade.GRADE " +
                                   "FROM update_grade " +
                                   "LEFT JOIN time_table ON update_grade.GRADE = time_table.GRADE " +
                                   "WHERE time_table.GRADE IS NULL";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string grade = reader["GRADE"].ToString();
                            comboBox_grade.Items.Add(grade);
                        }
                    }

                    // Query to retrieve all SUB_ID values from the subject table
                    string query2 = "SELECT SUB_ID FROM subject";

                    using (MySqlCommand cmd = new MySqlCommand(query2, connection))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader["SUB_ID"] != DBNull.Value)
                            {

                                int subId = Convert.ToInt32(reader["SUB_ID"]);
                                comboBox_M_1.Items.Add(subId.ToString());
                                comboBox_M_2.Items.Add(subId.ToString());
                                comboBox_M_3.Items.Add(subId.ToString());
                                comboBox_M_4.Items.Add(subId.ToString());
                                comboBox_M_5.Items.Add(subId.ToString());
                                comboBox_M_6.Items.Add(subId.ToString());
                                comboBox_M_7.Items.Add(subId.ToString());
                                comboBox_M_8.Items.Add(subId.ToString());
                                comboBox_Tu_1.Items.Add(subId.ToString());
                                comboBox_Tu_2.Items.Add(subId.ToString());
                                comboBox_Tu_3.Items.Add(subId.ToString());
                                comboBox_Tu_4.Items.Add(subId.ToString());
                                comboBox_Tu_5.Items.Add(subId.ToString());
                                comboBox_Tu_6.Items.Add(subId.ToString());
                                comboBox_Tu_7.Items.Add(subId.ToString());
                                comboBox_Tu_8.Items.Add(subId.ToString());

                                comboBox_W_1.Items.Add(subId.ToString());
                                comboBox_W_2.Items.Add(subId.ToString());
                                comboBox_W_3.Items.Add(subId.ToString());
                                comboBox_W_4.Items.Add(subId.ToString());
                                comboBox_W_5.Items.Add(subId.ToString());
                                comboBox_W_6.Items.Add(subId.ToString());
                                comboBox_W_7.Items.Add(subId.ToString());
                                comboBox_W_8.Items.Add(subId.ToString());

                                comboBox_Th_1.Items.Add(subId.ToString());
                                comboBox_Th_2.Items.Add(subId.ToString());
                                comboBox_Th_3.Items.Add(subId.ToString());
                                comboBox_Th_4.Items.Add(subId.ToString());
                                comboBox_Th_5.Items.Add(subId.ToString());
                                comboBox_Th_6.Items.Add(subId.ToString());
                                comboBox_Th_7.Items.Add(subId.ToString());
                                comboBox_Th_8.Items.Add(subId.ToString());

                                comboBox_F_1.Items.Add(subId.ToString());
                                comboBox_F_2.Items.Add(subId.ToString());
                                comboBox_F_3.Items.Add(subId.ToString());
                                comboBox_F_4.Items.Add(subId.ToString());
                                comboBox_F_5.Items.Add(subId.ToString());
                                comboBox_F_6.Items.Add(subId.ToString());
                                comboBox_F_7.Items.Add(subId.ToString());
                                comboBox_F_8.Items.Add(subId.ToString());
                            
                        }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }            
        }
        private bool AreAllComboBoxesSelected()
        {
            string[] dayComboBoxes = { "M", "Tu", "W", "Th", "F" };
            int[] periodComboBoxes = { 1, 2, 3, 4, 5, 6, 7, 8 };

            foreach (var day in dayComboBoxes)
            {
                foreach (var period in periodComboBoxes)
                {
                    string comboBoxName = $"comboBox_{day}_{period}";
                    ComboBox comboBox = Controls.Find(comboBoxName, true).FirstOrDefault() as ComboBox;

                    if (comboBox != null && comboBox.SelectedItem == null)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        private void buttonADD_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Check if grade is selected
                    if (string.IsNullOrEmpty(comboBox_grade.SelectedItem?.ToString()))
                    {
                        MessageBox.Show("Please select a grade.");
                        return;
                    }

                    // Check if any ComboBox is empty
                    if (!AreAllComboBoxesSelected())
                    {
                        MessageBox.Show("Please enter data into all ComboBoxes.");
                        return;
                    }

                    grade = comboBox_grade.SelectedItem?.ToString();

                    string[] dayComboBoxes = { "M", "Tu", "W", "Th", "F" };
                    int[] periodComboBoxes = { 1, 2, 3, 4, 5, 6, 7, 8 };

                    foreach (var day in dayComboBoxes)
                    {
                        foreach (var period in periodComboBoxes)
                        {
                            string comboBoxName = $"comboBox_{day}_{period}";
                            ComboBox comboBox = Controls.Find(comboBoxName, true).FirstOrDefault() as ComboBox;

                            if (comboBox != null)
                            {
                                InsertDataForComboBox(comboBox, day, period);
                            }
                        }
                    }

                    MessageBox.Show("Data inserted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        private void InsertDataForComboBox(ComboBox comboBox, string day, int period)
        {
            try
            {
                if (comboBox.SelectedItem != null && int.TryParse(comboBox.SelectedItem.ToString(), out int subId) && subId != 0)
                {
                    string query = "INSERT INTO time_table (GRADE, DAYTE, PERIOD, SUB_ID) VALUES (@grade, @day, @period, @subId);";
                    InsertData(query, grade, day, period, subId);
                }
                else
                {
                    MessageBox.Show($"Please select a valid subject id for {day} period {period}.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void InsertData(string query, string grade, string day, int period, int subId)
        {
            try
            {
                ConnectionDB connect = new ConnectionDB();
                MySqlConnection connection = connect.ConnectDB();
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@grade", grade);
                command.Parameters.AddWithValue("@day", day);
                command.Parameters.AddWithValue("@period", period);
                command.Parameters.AddWithValue("@subId", subId);

                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

        
    
}
