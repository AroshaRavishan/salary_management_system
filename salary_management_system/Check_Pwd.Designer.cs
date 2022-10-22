
namespace salary_management_system
{
    partial class Check_Pwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_Pwd));
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_user_ID = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.pictureBox_emp = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Gobold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(512, 270);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '#';
            this.txt_password.Size = new System.Drawing.Size(244, 29);
            this.txt_password.TabIndex = 39;
            // 
            // txt_user_ID
            // 
            this.txt_user_ID.Font = new System.Drawing.Font("Gobold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_ID.Location = new System.Drawing.Point(512, 181);
            this.txt_user_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user_ID.Multiline = true;
            this.txt_user_ID.Name = "txt_user_ID";
            this.txt_user_ID.Size = new System.Drawing.Size(244, 29);
            this.txt_user_ID.TabIndex = 38;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_login.Font = new System.Drawing.Font("Gobold Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(331, 387);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(165, 50);
            this.btn_login.TabIndex = 40;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Gobold Thin", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Aqua;
            this.lblPassword.Location = new System.Drawing.Point(323, 255);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(159, 43);
            this.lblPassword.TabIndex = 37;
            this.lblPassword.Text = "Password";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Gobold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.Aqua;
            this.lblUserID.Location = new System.Drawing.Point(323, 166);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(119, 43);
            this.lblUserID.TabIndex = 36;
            this.lblUserID.Text = "User ID";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_clear.Font = new System.Drawing.Font("Gobold Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(591, 387);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(165, 50);
            this.btn_clear.TabIndex = 41;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Image = global::salary_management_system.Properties.Resources.WhatsApp_Image_2021_05_05_at_10_31_38__2_;
            this.pictureBox_home.Location = new System.Drawing.Point(1015, 13);
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
            this.pictureBox_emp.Size = new System.Drawing.Size(85, 92);
            this.pictureBox_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_emp.TabIndex = 80;
            this.pictureBox_emp.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Gobold Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.lblLogin.Location = new System.Drawing.Point(116, 33);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(322, 52);
            this.lblLogin.TabIndex = 79;
            this.lblLogin.Text = "Check Password";
            // 
            // Check_Pwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1080, 564);
            this.Controls.Add(this.pictureBox_emp);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user_ID);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Check_Pwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check_Pwd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_user_ID;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.PictureBox pictureBox_emp;
        private System.Windows.Forms.Label lblLogin;
    }
}