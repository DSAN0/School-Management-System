namespace SCHOOL_SYSTEM
{
    partial class StudentMenu
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
            this.buttonHomeWork = new System.Windows.Forms.Button();
            this.buttonTimeTable = new System.Windows.Forms.Button();
            this.buttonExamResult = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMenu.Controls.Add(this.buttonHomeWork);
            this.panelMenu.Controls.Add(this.buttonTimeTable);
            this.panelMenu.Controls.Add(this.buttonExamResult);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(309, 753);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonHomeWork
            // 
            this.buttonHomeWork.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHomeWork.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHomeWork.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHomeWork.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHomeWork.Location = new System.Drawing.Point(0, 359);
            this.buttonHomeWork.Name = "buttonHomeWork";
            this.buttonHomeWork.Size = new System.Drawing.Size(309, 94);
            this.buttonHomeWork.TabIndex = 2;
            this.buttonHomeWork.Text = "VIWE HOME WORK";
            this.buttonHomeWork.UseVisualStyleBackColor = false;
            this.buttonHomeWork.Click += new System.EventHandler(this.buttonHomeWork_Click);
            // 
            // buttonTimeTable
            // 
            this.buttonTimeTable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTimeTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTimeTable.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeTable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTimeTable.Location = new System.Drawing.Point(0, 269);
            this.buttonTimeTable.Name = "buttonTimeTable";
            this.buttonTimeTable.Size = new System.Drawing.Size(309, 90);
            this.buttonTimeTable.TabIndex = 1;
            this.buttonTimeTable.Text = "VIWE TIME TABLE ";
            this.buttonTimeTable.UseVisualStyleBackColor = false;
            this.buttonTimeTable.Click += new System.EventHandler(this.buttonTimeTable_Click);
            // 
            // buttonExamResult
            // 
            this.buttonExamResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExamResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExamResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExamResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExamResult.Location = new System.Drawing.Point(0, 170);
            this.buttonExamResult.Name = "buttonExamResult";
            this.buttonExamResult.Size = new System.Drawing.Size(309, 99);
            this.buttonExamResult.TabIndex = 0;
            this.buttonExamResult.Text = "VIWE EXAM RESULT";
            this.buttonExamResult.UseVisualStyleBackColor = false;
            this.buttonExamResult.Click += new System.EventHandler(this.buttonExamResult_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(309, 170);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(309, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1373, 753);
            this.panelChildForm.TabIndex = 2;
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 753);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.Name = "StudentMenu";
            this.Text = "StudentMenu";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonHomeWork;
        private System.Windows.Forms.Button buttonTimeTable;
        private System.Windows.Forms.Button buttonExamResult;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
    }
}