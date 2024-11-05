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
    public partial class PrincipalLogin : Form
    {
        public PrincipalLogin()
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

                string query = "SELECT * FROM prinsipal_details WHERE NAME = @Username AND P_INDEX = @Password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", chekcusername);
                command.Parameters.AddWithValue("@Password", checkpassword);

                MySqlDataReader reader = command.ExecuteReader(); // Use MySqlDataReader here

                if (reader.Read())
                {
                    // Login successful
                    PrincipalMenu principalMenu = new PrincipalMenu();
                    principalMenu.Show();
                    this.Close();
                    // MessageBox.Show("Login successful!");

                    // Close the login form or navigate to the main application form
                }
                else
                {
                    // Login failed
                    MessageBox.Show("Login failed. Please check your id and password.");
                }

                connection.Close();
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void PrincipalLogin_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            

            string userId = textBox_user_id.Text;
            string passwordText = textBox_password.Text;

            // Check if userId and passwordText are not empty and passwordText can be converted to an integer
            if (!string.IsNullOrWhiteSpace(userId) && int.TryParse(passwordText, out int password))
            {
                CheckPassword(userId, password);
            }
            else
            {
                MessageBox.Show("Login failed. Please check your id and password.");
            }
        }
    }
}
