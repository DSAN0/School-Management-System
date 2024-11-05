namespace SCHOOL_SYSTEM
{
    partial class Form1
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
            this.buttonteacher = new System.Windows.Forms.Button();
            this.buttonstudent = new System.Windows.Forms.Button();
            this.button_principl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonteacher
            // 
            this.buttonteacher.BackColor = System.Drawing.Color.Black;
            this.buttonteacher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonteacher.Font = new System.Drawing.Font("Montserrat SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonteacher.ForeColor = System.Drawing.Color.White;
            this.buttonteacher.Image = global::SCHOOL_SYSTEM.Properties.Resources._9bfh41;
            this.buttonteacher.Location = new System.Drawing.Point(407, 534);
            this.buttonteacher.Name = "buttonteacher";
            this.buttonteacher.Size = new System.Drawing.Size(327, 83);
            this.buttonteacher.TabIndex = 1;
            this.buttonteacher.Text = "TEACHER";
            this.buttonteacher.UseVisualStyleBackColor = false;
            this.buttonteacher.Click += new System.EventHandler(this.buttonteacher_Click);
            // 
            // buttonstudent
            // 
            this.buttonstudent.BackColor = System.Drawing.Color.Black;
            this.buttonstudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonstudent.Font = new System.Drawing.Font("Montserrat SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonstudent.ForeColor = System.Drawing.Color.Transparent;
            this.buttonstudent.Image = global::SCHOOL_SYSTEM.Properties.Resources._9bfh41;
            this.buttonstudent.Location = new System.Drawing.Point(787, 534);
            this.buttonstudent.Name = "buttonstudent";
            this.buttonstudent.Size = new System.Drawing.Size(327, 83);
            this.buttonstudent.TabIndex = 2;
            this.buttonstudent.Text = "STUDENT";
            this.buttonstudent.UseVisualStyleBackColor = false;
            this.buttonstudent.Click += new System.EventHandler(this.buttonstudent_Click);
            // 
            // button_principl
            // 
            this.button_principl.BackColor = System.Drawing.SystemColors.Control;
            this.button_principl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_principl.Font = new System.Drawing.Font("Montserrat SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_principl.ForeColor = System.Drawing.Color.White;
            this.button_principl.Image = global::SCHOOL_SYSTEM.Properties.Resources._9bfh41;
            this.button_principl.Location = new System.Drawing.Point(28, 531);
            this.button_principl.Name = "button_principl";
            this.button_principl.Size = new System.Drawing.Size(327, 83);
            this.button_principl.TabIndex = 0;
            this.button_principl.Text = "PRINCIPAL";
            this.button_principl.UseVisualStyleBackColor = false;
            this.button_principl.Click += new System.EventHandler(this.button_principl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_principl);
            this.panel1.Controls.Add(this.buttonteacher);
            this.panel1.Controls.Add(this.buttonstudent);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(37, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 617);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SCHOOL_SYSTEM.Properties.Resources.anime_schoolgirl_clipart_xl;
            this.pictureBox3.Location = new System.Drawing.Point(787, 217);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(327, 249);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SCHOOL_SYSTEM.Properties.Resources.math_teacher_clipart_xl;
            this.pictureBox2.Location = new System.Drawing.Point(407, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 249);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCHOOL_SYSTEM.Properties.Resources.school_principal_clipart_xl;
            this.pictureBox1.Location = new System.Drawing.Point(28, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SCHOOL_SYSTEM.Properties.Resources._35188211_school3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1207, 671);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_principl;
        private System.Windows.Forms.Button buttonteacher;
        private System.Windows.Forms.Button buttonstudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

