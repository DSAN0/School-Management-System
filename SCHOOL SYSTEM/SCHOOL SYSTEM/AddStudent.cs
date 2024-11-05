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
using System.Data.SqlClient;

namespace SCHOOL_SYSTEM
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();

            // Add years to comboBoxNewStudentBatch
            //for (int year = 2001; year <= 2010; year++)
            //{
            //  comboBoxNewStudentBatch.Items.Add(year.ToString());
            //}

            addBatchComboBox();

        }
        private void addBatchComboBox()
        {
            try
            {
                ConnectionDB connet = new ConnectionDB();
                MySqlConnection connection = connet.ConnectDB();
                connection.Open();

                string query = "SELECT DISTINCT Batch FROM update_grade";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxNewStudentBatch.Items.Add(reader["Batch"].ToString());
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void AddNewStudent(int studentIndex, int studentBatch, string studentName, string studentAddress, DateTime studentDOB, int studentPhoneNumber, string studentGender)
        {
            try
            {
                ConnectionDB connet = new ConnectionDB();
                MySqlConnection connection = connet.ConnectDB();
                connection.Open();

                string query = "INSERT INTO student_details VALUES (@StudentIndex, @Batch, @StudentName, @Gender,@Address, @DOB, @PhoneNumber)";

                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@StudentIndex", studentIndex);
                command.Parameters.AddWithValue("@Batch", studentBatch);
                command.Parameters.AddWithValue("@StudentName", studentName);
                command.Parameters.AddWithValue("@Address", studentAddress);
                command.Parameters.AddWithValue("@DOB", studentDOB);
                command.Parameters.AddWithValue("@PhoneNumber", studentPhoneNumber);
                command.Parameters.AddWithValue("@Gender", studentGender);

                command.ExecuteNonQuery();

                connection.Close();
            }catch (Exception ex) 
            { throw new Exception("Database error: " + ex.Message); }
        }

        private void ClearForm()
        {
            // Clear input fields
            textBoxNewStudentIndex.Clear();
            textBoxNewStudentName.Clear();
            textBoxNewStudentAddres.Clear();
            textBoxNewStudentPhon.Clear();
            radioButtonMail.Checked = false;
            radioButtonFeemail.Checked = false;

            // Reset ComboBox to the default value (e.g., the first item)
            comboBoxNewStudentBatch.SelectedIndex = 0;

            // Reset DateTimePicker to today's date or any default date you prefer
            dateTimePickerNewStudentDOB.Value = DateTime.Today;
        }


        private void buttonADD_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation for Student Index
                string studentIndexText = textBoxNewStudentIndex.Text;
                if (!int.TryParse(studentIndexText, out int studentIndex) || studentIndexText.Length != 5)
                {
                    throw new Exception("Student Index must be a 5-digit integer.");
                }

                // Validation for Batch (ComboBox)
                if (!int.TryParse(comboBoxNewStudentBatch.SelectedItem.ToString(), out int studentBatch))
                {
                    throw new Exception("Invalid Batch value.");
                }

                // Validation for Student Name (string)
                string studentName = textBoxNewStudentName.Text;
                if (string.IsNullOrWhiteSpace(studentName))
                {
                    throw new Exception("Student Name cannot be empty.");
                }

                // Validation for Address (string)
                string studentAddress = textBoxNewStudentAddres.Text;

                // Validation for Date of Birth (DateTime)
                DateTime studentDOB = dateTimePickerNewStudentDOB.Value;

                // Validation for Phone Number
                string studentPhoneNumberText = textBoxNewStudentPhon.Text;
                if (!int.TryParse(studentPhoneNumberText, out int studentPhoneNumber) || studentPhoneNumberText.Length != 10)
                {
                    throw new Exception("Phone Number must be a 10-digit integer.");
                }

                // Validation for Gender (radio buttons)
                string studentGender = radioButtonMail.Checked ? "Male" : "Female";

                // If all validations pass, call the database connection method
                AddNewStudent(studentIndex, studentBatch, studentName, studentAddress, studentDOB, studentPhoneNumber, studentGender);

                MessageBox.Show("Student information added successfully.");
                
                ClearForm();
            }
            catch (Exception ex)
            { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}
