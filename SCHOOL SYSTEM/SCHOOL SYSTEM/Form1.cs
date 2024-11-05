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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_principl_Click(object sender, EventArgs e)
        {

            PrincipalLogin principal = new PrincipalLogin();
            principal.Show();
            this.Hide();
            
        }

        private void buttonteacher_Click(object sender, EventArgs e)
        {
            TeacherLogin teacherLogin = new TeacherLogin(); 
            teacherLogin.Show();
            this.Hide();
        }

        private void buttonstudent_Click(object sender, EventArgs e)
        {
            StudentLogin studentLogin = new StudentLogin();
            studentLogin.Show();    
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 176, 196, 222);
        }
    }
}
