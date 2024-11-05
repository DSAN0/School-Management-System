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
    public partial class PrincipalMenu : Form
    {
        public PrincipalMenu()
        {
            InitializeComponent();
        }

        private void buttonNewStudent_Click(object sender, EventArgs e)
        {
            openChildForm(new AddStudent());          
        }

        private void buttonNewTeacher_Click(object sender, EventArgs e)
        {
            openChildForm(new AddTeacher());

        }

        private void buttonNewTimeTable_Click(object sender, EventArgs e)
        {
            openChildForm(new AddTimeTable());

        }

        private void buttonStudentResult_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentResults());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new StudentsAttendans());

        }

        private void buttonPassGrade_Click(object sender, EventArgs e)
        {
            openChildForm(new BatchPassNewGrade());
        }

        private void buttonRemovePasteYear_Click(object sender, EventArgs e)
        {
           openChildForm(new RemovePasteYear());
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
