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
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }


        public void CheckPassword(string username, int password)
        {
            try
            {
                string chekcusername = username;
                int checkpassword = password;

                ConnectionDB connet = new ConnectionDB();
                MySqlConnection connection = connet.ConnectDB();
                connection.Open();

                string query = "SELECT * FROM student_details WHERE NAME = @Username AND S_INDEX = @Password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", chekcusername);
                command.Parameters.AddWithValue("@Password", checkpassword);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Login successful
                    StudentMenu studentMenu = new StudentMenu();
                    studentMenu.Show();
                    this.Close();
                }
                else
                {
                    // Login failed
                    MessageBox.Show("Login failed. Please check your user id or password.");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            

            string userId = textBox_user_id.Text;
            string passwordText = textBox_password.Text;

            if (!string.IsNullOrWhiteSpace(userId) && int.TryParse(passwordText, out int password))
            {
                CheckPassword(userId, password);
            }
            else
            {
                MessageBox.Show("Login failed. Please check your user id or password.");
            }

        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
