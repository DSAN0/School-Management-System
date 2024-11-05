namespace SCHOOL_SYSTEM
{
    partial class BatchPassNewGrade
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
            this.textBoxBatch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPass = new System.Windows.Forms.Button();
            this.comboBoxgrade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 37);
            this.label5.TabIndex = 108;
            this.label5.Text = "NEW BATCH :";
            // 
            // textBoxBatch
            // 
            this.textBoxBatch.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBatch.Location = new System.Drawing.Point(484, 316);
            this.textBoxBatch.Name = "textBoxBatch";
            this.textBoxBatch.Size = new System.Drawing.Size(383, 37);
            this.textBoxBatch.TabIndex = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 37);
            this.label3.TabIndex = 106;
            this.label3.Text = "grade :";
            // 
            // buttonPass
            // 
            this.buttonPass.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPass.Location = new System.Drawing.Point(577, 468);
            this.buttonPass.Name = "buttonPass";
            this.buttonPass.Size = new System.Drawing.Size(129, 59);
            this.buttonPass.TabIndex = 105;
            this.buttonPass.Text = "PASS";
            this.buttonPass.UseVisualStyleBackColor = true;
            this.buttonPass.Click += new System.EventHandler(this.buttonPass_Click);
            // 
            // comboBoxgrade
            // 
            this.comboBoxgrade.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxgrade.FormattingEnabled = true;
            this.comboBoxgrade.Location = new System.Drawing.Point(484, 189);
            this.comboBoxgrade.Name = "comboBoxgrade";
            this.comboBoxgrade.Size = new System.Drawing.Size(383, 35);
            this.comboBoxgrade.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 51);
            this.label1.TabIndex = 103;
            this.label1.Text = "BATCH PASS NEW GRADE";
            // 
            // BatchPassNewGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 753);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBatch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPass);
            this.Controls.Add(this.comboBoxgrade);
            this.Controls.Add(this.label1);
            this.Name = "BatchPassNewGrade";
            this.Text = "BatchPassNewGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPass;
        private System.Windows.Forms.ComboBox comboBoxgrade;
        private System.Windows.Forms.Label label1;
    }
}