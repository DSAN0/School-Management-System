namespace SCHOOL_SYSTEM
{
    partial class TeacherMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonAttendancyMark = new System.Windows.Forms.Button();
            this.buttonExamsResults = new System.Windows.Forms.Button();
            this.buttonTimeTable = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.buttonStudentHomework = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMenu.Controls.Add(this.buttonStudentHomework);
            this.panelMenu.Controls.Add(this.buttonAttendancyMark);
            this.panelMenu.Controls.Add(this.buttonExamsResults);
            this.panelMenu.Controls.Add(this.buttonTimeTable);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(309, 753);
            this.panelMenu.TabIndex = 2;
            // 
            // buttonAttendancyMark
            // 
            this.buttonAttendancyMark.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAttendancyMark.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAttendancyMark.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttendancyMark.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAttendancyMark.Location = new System.Drawing.Point(0, 353);
            this.buttonAttendancyMark.Name = "buttonAttendancyMark";
            this.buttonAttendancyMark.Size = new System.Drawing.Size(309, 94);
            this.buttonAttendancyMark.TabIndex = 2;
            this.buttonAttendancyMark.Text = "STUDENT ATTENDANCY MARK";
            this.buttonAttendancyMark.UseVisualStyleBackColor = false;
            this.buttonAttendancyMark.Click += new System.EventHandler(this.buttonAttendancyMark_Click);
            // 
            // buttonExamsResults
            // 
            this.buttonExamsResults.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExamsResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExamsResults.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExamsResults.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExamsResults.Location = new System.Drawing.Point(0, 263);
            this.buttonExamsResults.Name = "buttonExamsResults";
            this.buttonExamsResults.Size = new System.Drawing.Size(309, 90);
            this.buttonExamsResults.TabIndex = 1;
            this.buttonExamsResults.Text = "ADD EXAMS RESULTS";
            this.buttonExamsResults.UseVisualStyleBackColor = false;
            this.buttonExamsResults.Click += new System.EventHandler(this.buttonExamsResults_Click);
            // 
            // buttonTimeTable
            // 
            this.buttonTimeTable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTimeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTimeTable.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeTable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTimeTable.Location = new System.Drawing.Point(0, 164);
            this.buttonTimeTable.Name = "buttonTimeTable";
            this.buttonTimeTable.Size = new System.Drawing.Size(309, 99);
            this.buttonTimeTable.TabIndex = 0;
            this.buttonTimeTable.Text = "VIWE TIME TABLE ";
            this.buttonTimeTable.UseVisualStyleBackColor = false;
            this.buttonTimeTable.Click += new System.EventHandler(this.buttonTimeTable_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(309, 164);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(309, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1373, 753);
            this.panelChildForm.TabIndex = 3;
            // 
            // buttonStudentHomework
            // 
            this.buttonStudentHomework.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStudentHomework.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudentHomework.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentHomework.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStudentHomework.Location = new System.Drawing.Point(0, 447);
            this.buttonStudentHomework.Name = "buttonStudentHomework";
            this.buttonStudentHomework.Size = new System.Drawing.Size(309, 94);
            this.buttonStudentHomework.TabIndex = 3;
            this.buttonStudentHomework.Text = "ADD STUDENT HOME WORK ";
            this.buttonStudentHomework.UseVisualStyleBackColor = false;
            this.buttonStudentHomework.Click += new System.EventHandler(this.buttonStudentHomework_Click);
            // 
            // TeacherMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 753);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.Name = "TeacherMenu";
            this.Text = "TeacherMenu";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonAttendancyMark;
        private System.Windows.Forms.Button buttonExamsResults;
        private System.Windows.Forms.Button buttonTimeTable;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button buttonStudentHomework;
    }
}