
namespace salary_management_system
{
    partial class CheckPwdMessage_box
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
            this.btn_splash_continue = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_user_ID = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_splash_continue
            // 
            this.btn_splash_continue.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_splash_continue.Font = new System.Drawing.Font("Gobold Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_splash_continue.Location = new System.Drawing.Point(425, 397);
            this.btn_splash_continue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_splash_continue.Name = "btn_splash_continue";
            this.btn_splash_continue.Size = new System.Drawing.Size(239, 57);
            this.btn_splash_continue.TabIndex = 42;
            this.btn_splash_continue.Text = "Continue";
            this.btn_splash_continue.UseVisualStyleBackColor = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_clear.Font = new System.Drawing.Font("Gobold Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(600, 328);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(165, 50);
            this.btn_clear.TabIndex = 41;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_login.Font = new System.Drawing.Font("Gobold Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(340, 328);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(165, 50);
            this.btn_login.TabIndex = 40;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Gobold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(521, 211);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(244, 29);
            this.txt_password.TabIndex = 39;
            // 
            // txt_user_ID
            // 
            this.txt_user_ID.Font = new System.Drawing.Font("Gobold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_ID.Location = new System.Drawing.Point(521, 122);
            this.txt_user_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user_ID.Multiline = true;
            this.txt_user_ID.Name = "txt_user_ID";
            this.txt_user_ID.Size = new System.Drawing.Size(244, 29);
            this.txt_user_ID.TabIndex = 38;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Gobold Thin", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Aqua;
            this.lblPassword.Location = new System.Drawing.Point(332, 196);
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
            this.lblUserID.Location = new System.Drawing.Point(332, 107);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(119, 43);
            this.lblUserID.TabIndex = 36;
            this.lblUserID.Text = "User ID";
            // 
            // CheckPwdMessage_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1096, 561);
            this.Controls.Add(this.btn_splash_continue);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user_ID);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserID);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckPwdMessage_box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckPwdMessage_box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_splash_continue;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_user_ID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
    }
}