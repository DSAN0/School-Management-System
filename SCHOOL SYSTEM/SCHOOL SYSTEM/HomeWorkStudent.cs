using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL_SYSTEM
{
    public partial class HomeWorkStudent : Form
    {
        public HomeWorkStudent()
        {
            InitializeComponent();
            InsertGrade();
            InsertSubjectid();
            InsertDate();
        }
        private void InsertGrade()
        {
            try
            {
                ConnectionDB connet = new ConnectionDB();
                MySqlConnection connection = connet.ConnectDB();
                connection.Open();
                string query = "SELECT DISTINCT GRADE FROM home_work";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxgrade.Items.Add(reader["GRADE"].ToString());
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void InsertSubjectid()
        {
            try
            {
                ConnectionDB connet = new ConnectionDB();
                MySqlConnection connection = connet.ConnectDB();
                connection.Open();
                string query = "SELECT DISTINCT SUB_ID FROM home_work";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxsubid.Items.Add(reader["SUB_ID"].ToString());
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        /* private void InsertDate() 
         {
             try
             {
                 ConnectionDB connet = new ConnectionDB();
                 MySqlConnection connection = connet.ConnectDB();
                 connection.Open();
                 string query = "SELECT DISTINCT DATE FROM home_work"; // Replace with your actual table name and column
                 MySqlCommand cmd = new MySqlCommand(query, connection);
                 MySqlDataReader reader = cmd.ExecuteReader();

                 while (reader.Read())
                 {
                     comboBoxdate.Items.Add(reader["DATE"].ToString());
                 }

                 reader.Close();
                 connection.Close();
                 MessageBox.Show("date is add sucsesfully");
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error: " + ex.Message);
             }
             finally
             {

             }
         }*/

        private void InsertDate()
        {
            try
            {
                ConnectionDB connet = new ConnectionDB();
                MySqlConnection connection = connet.ConnectDB();
                connection.Open();
                string query = "SELECT DISTINCT DATE FROM home_work"; // Replace with your actual table name and column
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxdate.Items.Add(reader["DATE"].ToString());
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InsertHomeWork(string selectedDate, string selectedGrade, string selectedSubid) 
        {
            ConnectionDB connet = new ConnectionDB();
            MySqlConnection connection = connet.ConnectDB();

            try
            {
                connection.Open();
                string query = "SELECT H_W_M FROM home_work WHERE GRADE = @grade AND SUB_ID = @subid AND DATE = @date";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@grade", selectedGrade);
                cmd.Parameters.AddWithValue("@subid", selectedSubid);
                cmd.Parameters.AddWithValue("@date", selectedDate);

                string homeworkText = "";

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string resultValue = reader["H_W_M"].ToString();
                        homeworkText += resultValue + Environment.NewLine;
                    }
                }

                // Display some debugging information
                Console.WriteLine($"Executing SQL query: {query}");
                Console.WriteLine($"Selected Date: {selectedDate}, Selected Grade: {selectedGrade}, Selected Subid: {selectedSubid}");

                if (string.IsNullOrWhiteSpace(homeworkText))
                {
                    MessageBox.Show("No homework data found for the selected criteria.");
                }
                else
                {
                    textBoxhomework.Text = homeworkText;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            //InsertDate();

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string selectedDate = comboBoxdate.SelectedItem?.ToString();
            string selectedGrade = comboBoxgrade.SelectedItem?.ToString();
            string selectedSubid = comboBoxsubid.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(selectedDate) || string.IsNullOrWhiteSpace(selectedGrade) || string.IsNullOrWhiteSpace(selectedSubid))
            {
                MessageBox.Show("Please select a date, grade, and subject ID.");
                return;
            }

            InsertHomeWork(selectedDate, selectedGrade, selectedSubid);

        }
    }
}
