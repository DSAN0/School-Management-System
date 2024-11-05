namespace SCHOOL_SYSTEM
{
    partial class AddResults
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
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.comboBoxgrade = new System.Windows.Forms.ComboBox();
            this.comboBoxbatch = new System.Windows.Forms.ComboBox();
            this.comboBoxsubid = new System.Windows.Forms.ComboBox();
            this.comboBoxresult = new System.Windows.Forms.ComboBox();
            this.textBoxexamname = new System.Windows.Forms.TextBox();
            this.buttonADD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxindex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "ADD RESULTS";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // comboBoxgrade
            // 
            this.comboBoxgrade.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxgrade.FormattingEnabled = true;
            this.comboBoxgrade.Location = new System.Drawing.Point(497, 167);
            this.comboBoxgrade.Name = "comboBoxgrade";
            this.comboBoxgrade.Size = new System.Drawing.Size(383, 35);
            this.comboBoxgrade.TabIndex = 61;
            // 
            // comboBoxbatch
            // 
            this.comboBoxbatch.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxbatch.FormattingEnabled = true;
            this.comboBoxbatch.Location = new System.Drawing.Point(497, 96);
            this.comboBoxbatch.Name = "comboBoxbatch";
            this.comboBoxbatch.Size = new System.Drawing.Size(383, 35);
            this.comboBoxbatch.TabIndex = 62;
            // 
            // comboBoxsubid
            // 
            this.comboBoxsubid.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxsubid.FormattingEnabled = true;
            this.comboBoxsubid.Location = new System.Drawing.Point(497, 352);
            this.comboBoxsubid.Name = "comboBoxsubid";
            this.comboBoxsubid.Size = new System.Drawing.Size(383, 35);
            this.comboBoxsubid.TabIndex = 63;
            // 
            // comboBoxresult
            // 
            this.comboBoxresult.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxresult.FormattingEnabled = true;
            this.comboBoxresult.Location = new System.Drawing.Point(497, 521);
            this.comboBoxresult.Name = "comboBoxresult";
            this.comboBoxresult.Size = new System.Drawing.Size(383, 35);
            this.comboBoxresult.TabIndex = 65;
            // 
            // textBoxexamname
            // 
            this.textBoxexamname.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxexamname.Location = new System.Drawing.Point(497, 415);
            this.textBoxexamname.Name = "textBoxexamname";
            this.textBoxexamname.Size = new System.Drawing.Size(383, 37);
            this.textBoxexamname.TabIndex = 76;
            // 
            // buttonADD
            // 
            this.buttonADD.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADD.Location = new System.Drawing.Point(598, 621);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(129, 59);
            this.buttonADD.TabIndex = 77;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 37);
            this.label3.TabIndex = 78;
            this.label3.Text = "grade :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 37);
            this.label2.TabIndex = 79;
            this.label2.Text = "batch :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(303, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 37);
            this.label4.TabIndex = 80;
            this.label4.Text = "subject id :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 37);
            this.label5.TabIndex = 81;
            this.label5.Text = "exam name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(365, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 37);
            this.label6.TabIndex = 82;
            this.label6.Text = "index :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(362, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 37);
            this.label7.TabIndex = 83;
            this.label7.Text = "result :";
            // 
            // textBoxindex
            // 
            this.textBoxindex.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxindex.Location = new System.Drawing.Point(497, 242);
            this.textBoxindex.Name = "textBoxindex";
            this.textBoxindex.Size = new System.Drawing.Size(383, 37);
            this.textBoxindex.TabIndex = 84;
            // 
            // AddResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 753);
            this.Controls.Add(this.textBoxindex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.textBoxexamname);
            this.Controls.Add(this.comboBoxresult);
            this.Controls.Add(this.comboBoxsubid);
            this.Controls.Add(this.comboBoxbatch);
            this.Controls.Add(this.comboBoxgrade);
            this.Controls.Add(this.label1);
            this.Name = "AddResults";
            this.Text = "AddResults";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ComboBox comboBoxgrade;
        private System.Windows.Forms.ComboBox comboBoxbatch;
        private System.Windows.Forms.ComboBox comboBoxsubid;
        private System.Windows.Forms.ComboBox comboBoxresult;
        private System.Windows.Forms.TextBox textBoxexamname;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxindex;
    }
}