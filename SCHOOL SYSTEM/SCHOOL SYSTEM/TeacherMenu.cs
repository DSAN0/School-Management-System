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
    public partial class TeacherMenu : Form
    {
        public TeacherMenu()
        {
            InitializeComponent();
        }

        private void buttonTimeTable_Click(object sender, EventArgs e)
        {
             openChildForm(new TimeTableTeacher());
        }

        private void buttonExamsResults_Click(object sender, EventArgs e)
        {
            openChildForm(new AddResults());

        }

        private void buttonAttendancyMark_Click(object sender, EventArgs e)
        {
            openChildForm(new AddAtendance());

        }

        private void buttonStudentHomework_Click(object sender, EventArgs e)
        {
            openChildForm(new AddHomeWork());

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
