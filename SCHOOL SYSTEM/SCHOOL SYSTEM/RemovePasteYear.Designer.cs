namespace SCHOOL_SYSTEM
{
    partial class RemovePasteYear
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRemoveAtendence = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRemoveHomeWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(537, 37);
            this.label5.TabIndex = 112;
            this.label5.Text = "HOME WORK PASTE YEAR REMOVE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(540, 37);
            this.label3.TabIndex = 111;
            this.label3.Text = "ATTENDENCE PASTE YEAR REMOVE :";
            // 
            // buttonRemoveAtendence
            // 
            this.buttonRemoveAtendence.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveAtendence.Location = new System.Drawing.Point(833, 266);
            this.buttonRemoveAtendence.Name = "buttonRemoveAtendence";
            this.buttonRemoveAtendence.Size = new System.Drawing.Size(257, 59);
            this.buttonRemoveAtendence.TabIndex = 110;
            this.buttonRemoveAtendence.Text = "REMOVE";
            this.buttonRemoveAtendence.UseVisualStyleBackColor = true;
            this.buttonRemoveAtendence.Click += new System.EventHandler(this.buttonRemoveAtendence_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 51);
            this.label1.TabIndex = 109;
            this.label1.Text = "REMOVE PAST YEAR";
            // 
            // buttonRemoveHomeWork
            // 
            this.buttonRemoveHomeWork.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveHomeWork.Location = new System.Drawing.Point(833, 365);
            this.buttonRemoveHomeWork.Name = "buttonRemoveHomeWork";
            this.buttonRemoveHomeWork.Size = new System.Drawing.Size(257, 59);
            this.buttonRemoveHomeWork.TabIndex = 113;
            this.buttonRemoveHomeWork.Text = "REMOVE";
            this.buttonRemoveHomeWork.UseVisualStyleBackColor = true;
            this.buttonRemoveHomeWork.Click += new System.EventHandler(this.buttonRemoveHomeWork_Click);
            // 
            // RemovePasteYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 753);
            this.Controls.Add(this.buttonRemoveHomeWork);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRemoveAtendence);
            this.Controls.Add(this.label1);
            this.Name = "RemovePasteYear";
            this.Text = "RemovePasteYear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRemoveAtendence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRemoveHomeWork;
    }
}