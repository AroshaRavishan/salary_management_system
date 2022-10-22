
namespace salary_management_system
{
    partial class Msg_Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Msg_Log));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_emp_posititon = new System.Windows.Forms.Label();
            this.cmb_position = new System.Windows.Forms.ComboBox();
            this.btn_add_msg = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btn_add_msg);
            this.panel1.Controls.Add(this.cmb_position);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_emp_posititon);
            this.panel1.Location = new System.Drawing.Point(-1, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 374);
            this.panel1.TabIndex = 39;
            // 
            // lbl_emp_posititon
            // 
            this.lbl_emp_posititon.AutoSize = true;
            this.lbl_emp_posititon.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_posititon.ForeColor = System.Drawing.Color.Red;
            this.lbl_emp_posititon.Location = new System.Drawing.Point(452, 93);
            this.lbl_emp_posititon.Name = "lbl_emp_posititon";
            this.lbl_emp_posititon.Size = new System.Drawing.Size(201, 31);
            this.lbl_emp_posititon.TabIndex = 35;
            this.lbl_emp_posititon.Text = "Employee Position";
            this.lbl_emp_posititon.Click += new System.EventHandler(this.lbl_emp_posititon_Click);
            // 
            // cmb_position
            // 
            this.cmb_position.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_position.FormattingEnabled = true;
            this.cmb_position.Items.AddRange(new object[] {
            "MANAGER",
            "DIRECTOR",
            "SENIOR DEVELOPPER",
            "JUNIOR DEVELOPPER",
            "ACCOUNTATNT",
            "RECEPTIONIST"});
            this.cmb_position.Location = new System.Drawing.Point(458, 151);
            this.cmb_position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(188, 30);
            this.cmb_position.TabIndex = 36;
            this.cmb_position.SelectedIndexChanged += new System.EventHandler(this.cmb_position_SelectedIndexChanged);
            // 
            // btn_add_msg
            // 
            this.btn_add_msg.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_add_msg.Font = new System.Drawing.Font("Gobold Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_msg.Location = new System.Drawing.Point(196, 241);
            this.btn_add_msg.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_msg.Name = "btn_add_msg";
            this.btn_add_msg.Size = new System.Drawing.Size(323, 57);
            this.btn_add_msg.TabIndex = 37;
            this.btn_add_msg.Text = "Add Meesage";
            this.btn_add_msg.UseVisualStyleBackColor = false;
            this.btn_add_msg.Click += new System.EventHandler(this.btn_splash_continue_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Gobold Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(646, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 57);
            this.button1.TabIndex = 38;
            this.button1.Text = "Check Messages";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Image = global::salary_management_system.Properties.Resources.WhatsApp_Image_2021_05_05_at_10_31_38__2_;
            this.pictureBox_home.Location = new System.Drawing.Point(1023, 13);
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
            this.pictureBox_emp.Location = new System.Drawing.Point(13, 9);
            this.pictureBox_emp.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_emp.Name = "pictureBox_emp";
            this.pictureBox_emp.Size = new System.Drawing.Size(97, 97);
            this.pictureBox_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_emp.TabIndex = 80;
            this.pictureBox_emp.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Gobold Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.lblLogin.Location = new System.Drawing.Point(128, 34);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(354, 52);
            this.lblLogin.TabIndex = 79;
            this.lblLogin.Text = "Message Box Login";
            // 
            // Msg_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1088, 557);
            this.Controls.Add(this.pictureBox_emp);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Msg_Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Msg_Log";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add_msg;
        private System.Windows.Forms.Label lbl_emp_posititon;
        private System.Windows.Forms.ComboBox cmb_position;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.PictureBox pictureBox_emp;
        private System.Windows.Forms.Label lblLogin;
    }
}