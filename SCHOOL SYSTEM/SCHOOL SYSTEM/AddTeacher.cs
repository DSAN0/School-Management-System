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

namespace SCHOOL_SYSTEM
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
            // Add subject IDs to comboBoxSubjectId
            SubjectComboBox();
        }

        private void SubjectComboBox()
        {
            // Connect to your database and fetch subject IDs
            ConnectionDB connet = new ConnectionDB();
            MySqlConnection connection = connet.ConnectDB();
            connection.Open();

            string query = "SELECT SUB_ID FROM subject";

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBoxSubjectId.Items.Add(reader["SUB_ID"].ToString());
            }

            reader.Close();
            connection.Close();
        }


        private void AddNewTeacher(int teacherIndex, int subjectId, string teacherName, string teacherAddress, DateTime teacherDOB, int teacherPhoneNumber, string teacherGender)
        {
            try
            {
                ConnectionDB connet = new ConnectionDB();
                MySqlConnection connection = connet.ConnectDB();
                connection.Open();

                string query = "INSERT INTO teacher_details  VALUES (@TeacherIndex, @SubjectId, @TeacherName, @Address,@Gender, @DOB, @PhoneNumber )";

                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@TeacherIndex", teacherIndex);
                command.Parameters.AddWithValue("@SubjectId", subjectId);
                command.Parameters.AddWithValue("@TeacherName", teacherName);
                command.Parameters.AddWithValue("@Address", teacherAddress);
                command.Parameters.AddWithValue("@DOB", teacherDOB);
                command.Parameters.AddWithValue("@PhoneNumber", teacherPhoneNumber);
                command.Parameters.AddWithValue("@Gender", teacherGender);

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Database error: " + ex.Message);
            }
        }


        private void ClearForm()
        {
            // Clear input fields
            textBoxNewTeacherIndex.Clear();
            textBoxNewTeacherName.Clear();
            textBoxNewTeacherAddres.Clear();
            textBoxNewTeacherPhon.Clear();
            radioButtonMail.Checked = false;
            radioButtonFeemail.Checked = false;

            // Reset ComboBox to the default value (e.g., the first item)
            comboBoxSubjectId.SelectedIndex = 0;

            // Reset DateTimePicker to today's date or any default date you prefer
            dateTimePickerNewTeacherDOB.Value = DateTime.Today;
        }


        private void buttonADD_Click(object sender, EventArgs e)
        {
            
            
                try
                {
                    // Validation for teacher Index (string)
                    string teacherIndexText = textBoxNewTeacherIndex.Text;
                    if (!int.TryParse(teacherIndexText, out int teacherIndex) || teacherIndexText.Length != 5)
                    {
                        throw new Exception("Teacher Index must be a 5-digit integer.");
                    }

                    // Validation for Batch (ComboBox)
                    if (!int.TryParse(comboBoxSubjectId.SelectedItem.ToString(), out int subjectId))
                    {
                        throw new Exception("Invalid subjectId value.");
                    }

                    // Validation for teacher Name (string)
                    string teacherName = textBoxNewTeacherName.Text;
                    if (string.IsNullOrWhiteSpace(teacherName))
                    {
                        throw new Exception("Teacher Name cannot be empty.");
                    }

                    // Validation for Address (string)
                    string teacherAddress = textBoxNewTeacherAddres.Text;

                    // Validation for Date of Birth (DateTime)
                    DateTime teacherDOB = dateTimePickerNewTeacherDOB.Value;

                    // Validation for Phone Number
                    string teacherPhoneNumberText = textBoxNewTeacherPhon.Text;
                    if (!int.TryParse(teacherPhoneNumberText, out int teacherPhoneNumber) || teacherPhoneNumberText.Length != 10)
                    {
                        throw new Exception("Phone Number must be a 10-digit integer.");
                    }

                    // Validation for Gender (radio buttons)
                    string teacherGender = radioButtonMail.Checked ? "Male" : "Female";

                    AddNewTeacher(teacherIndex, subjectId, teacherName, teacherAddress, teacherDOB, teacherPhoneNumber, teacherGender);

                    MessageBox.Show("Teacher information added successfully.");

                    // Clear the form for the next new teacher
                    ClearForm();

            }
                catch (Exception ex)
                { MessageBox.Show("Error: " + ex.Message); }

            

        }
    }
}
