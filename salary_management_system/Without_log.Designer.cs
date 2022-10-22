
namespace salary_management_system
{
    partial class Without_log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Without_log));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblmsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.pictureBox_emp = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblmsg);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 365);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Gobold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.ForeColor = System.Drawing.Color.Navy;
            this.lblmsg.Location = new System.Drawing.Point(433, 123);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(149, 43);
            this.lblmsg.TabIndex = 56;
            this.lblmsg.Text = "Message ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Gobold Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(380, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 57);
            this.button1.TabIndex = 39;
            this.button1.Text = "Check Messages";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Image = global::salary_management_system.Properties.Resources.WhatsApp_Image_2021_05_05_at_10_31_38__2_;
            this.pictureBox_home.Location = new System.Drawing.Point(1033, 13);
            this.pictureBox_home.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(52, 52);
            this.pictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_home.TabIndex = 78;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // pictureBox_emp
            // 
            this.pictureBox_emp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_emp.Image")));
            this.pictureBox_emp.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_emp.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_emp.Name = "pictureBox_emp";
            this.pictureBox_emp.Size = new System.Drawing.Size(113, 96);
            this.pictureBox_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_emp.TabIndex = 80;
            this.pictureBox_emp.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Gobold Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.lblLogin.Location = new System.Drawing.Point(149, 38);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(291, 52);
            this.lblLogin.TabIndex = 79;
            this.lblLogin.Text = "Check Message";
            // 
            // Without_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1098, 563);
            this.Controls.Add(this.pictureBox_emp);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Without_log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Without_log";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.PictureBox pictureBox_emp;
        private System.Windows.Forms.Label lblLogin;
    }
}