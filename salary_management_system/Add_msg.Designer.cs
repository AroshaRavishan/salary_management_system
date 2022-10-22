
namespace salary_management_system
{
    partial class Add_msg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_msg));
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.btn_emp_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncheck_msg = new System.Windows.Forms.Button();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.pictureBox_emp = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("Gobold Thin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.Location = new System.Drawing.Point(68, 91);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(1026, 37);
            this.txtMsg.TabIndex = 40;
            this.txtMsg.TextChanged += new System.EventHandler(this.txtMsg_TextChanged);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(652, 243);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 17);
            this.lblmsg.TabIndex = 38;
            // 
            // btn_emp_add
            // 
            this.btn_emp_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_emp_add.Font = new System.Drawing.Font("Gobold Thin Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emp_add.Location = new System.Drawing.Point(245, 175);
            this.btn_emp_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_emp_add.Name = "btn_emp_add";
            this.btn_emp_add.Size = new System.Drawing.Size(248, 112);
            this.btn_emp_add.TabIndex = 37;
            this.btn_emp_add.Text = "Save Message";
            this.btn_emp_add.UseVisualStyleBackColor = false;
            this.btn_emp_add.Click += new System.EventHandler(this.btn_emp_add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btncheck_msg);
            this.panel1.Controls.Add(this.btn_emp_add);
            this.panel1.Controls.Add(this.txtMsg);
            this.panel1.Location = new System.Drawing.Point(3, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 393);
            this.panel1.TabIndex = 41;
            // 
            // btncheck_msg
            // 
            this.btncheck_msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncheck_msg.Font = new System.Drawing.Font("Gobold Thin Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck_msg.Location = new System.Drawing.Point(652, 175);
            this.btncheck_msg.Margin = new System.Windows.Forms.Padding(4);
            this.btncheck_msg.Name = "btncheck_msg";
            this.btncheck_msg.Size = new System.Drawing.Size(248, 112);
            this.btncheck_msg.TabIndex = 41;
            this.btncheck_msg.Text = "Check Message";
            this.btncheck_msg.UseVisualStyleBackColor = false;
            this.btncheck_msg.Click += new System.EventHandler(this.btncheck_msg_Click);
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Image = global::salary_management_system.Properties.Resources.WhatsApp_Image_2021_05_05_at_10_31_38__2_;
            this.pictureBox_home.Location = new System.Drawing.Point(1093, 13);
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
            this.lblLogin.Location = new System.Drawing.Point(160, 40);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(252, 52);
            this.lblLogin.TabIndex = 79;
            this.lblLogin.Text = "Add Message";
            // 
            // Add_msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1158, 602);
            this.Controls.Add(this.pictureBox_emp);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblmsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_msg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_msg";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Button btn_emp_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncheck_msg;
        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.PictureBox pictureBox_emp;
        private System.Windows.Forms.Label lblLogin;
    }
}