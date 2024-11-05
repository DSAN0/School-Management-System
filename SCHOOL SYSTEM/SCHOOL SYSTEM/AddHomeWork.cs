using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class AddHomeWork : Form
    {


        public AddHomeWork()
        {
            InitializeComponent();
            InsertGrade();
            InsertSubjectid();
        
        }

        private void InsertGrade() 
        {
            try
            {
                ConnectionDB connet = new ConnectionDB();
                MySqlConnection connection = connet.ConnectDB();
                connection.Open();
                //string query = "DELECT DISTINCT GRADE FROM update_grade";
                string query = "SELECT DISTINCT GRADE FROM update_grade";
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
            finally
            {
 
            }
        }
        private void InsertSubjectid()
        {
            try
            {
                ConnectionDB connet = new ConnectionDB();
                MySqlConnection connection = connet.ConnectDB();
                connection.Open();
                string query = "SELECT DISTINCT SUB_ID FROM subject"; // Replace with your actual table name and column
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
            finally
            {
               
            }
        }
        private void AddNewHomework(string grade , int sub_id ,DateTime Date , string h_w_m)
        {
            try
            {
                ConnectionDB connet = new ConnectionDB();
                MySqlConnection connection = connet.ConnectDB();
                connection.Open();

                string query = "INSERT INTO home_work  VALUES (@GRADE, @SUB_ID, @DATE, @H_W_M )";

                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@GRADE", grade);
                command.Parameters.AddWithValue("@SUB_ID", sub_id);
                command.Parameters.AddWithValue("@DATE", Date);
                command.Parameters.AddWithValue("@H_W_M", h_w_m);
                

                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("home work add completed");
            }
            catch (Exception ex)
            {
                throw new Exception("Database error: " + ex.Message);
            }
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            try {
                if (comboBoxgrade.SelectedItem != null && comboBoxsubid.SelectedItem != null &&
                    !string.IsNullOrWhiteSpace(textBoxhomework.Text))
                {
                    DateTime dateTime = dateTimePicker1.Value;
                    string grade = comboBoxgrade.SelectedItem.ToString();
                    int sub_id = Convert.ToInt32(comboBoxsubid.SelectedItem.ToString());
                    string h_w_m = textBoxhomework.Text;
                   
                    AddNewHomework( grade,  sub_id, dateTime, h_w_m);


                }

            } catch (Exception ex) { MessageBox.Show("error "+ex.Message); }
        }
    }
}
