
namespace salary_management_system
{
    partial class Employee_manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_manage));
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comb_emp_gender = new System.Windows.Forms.ComboBox();
            this.txt_emp_gender = new System.Windows.Forms.Label();
            this.txt_emp_name = new System.Windows.Forms.TextBox();
            this.lbl_emp_name = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_emp_address = new System.Windows.Forms.TextBox();
            this.txt_emp_ID = new System.Windows.Forms.TextBox();
            this.datetime_DOB = new System.Windows.Forms.DateTimePicker();
            this.lbl_emp_Bday = new System.Windows.Forms.Label();
            this.comb_education = new System.Windows.Forms.ComboBox();
            this.lbl_emp_education = new System.Windows.Forms.Label();
            this.lbl_emp_phone = new System.Windows.Forms.Label();
            this.cmb_position = new System.Windows.Forms.ComboBox();
            this.lbl_emp_posititon = new System.Windows.Forms.Label();
            this.lbl_emp_address = new System.Windows.Forms.Label();
            this.lbl1_emp_id = new System.Windows.Forms.Label();
            this.btn_emp_add = new System.Windows.Forms.Button();
            this.pictureBox_emp = new System.Windows.Forms.PictureBox();
            this.btn_emp_manage_view = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.DGVUpdatedetails = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUpdatedetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Gobold Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.lblLogin.Location = new System.Drawing.Point(156, 34);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(338, 52);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Manage Employee";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comb_emp_gender);
            this.panel1.Controls.Add(this.txt_emp_gender);
            this.panel1.Controls.Add(this.txt_emp_name);
            this.panel1.Controls.Add(this.lbl_emp_name);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.txt_emp_address);
            this.panel1.Controls.Add(this.txt_emp_ID);
            this.panel1.Controls.Add(this.datetime_DOB);
            this.panel1.Controls.Add(this.lbl_emp_Bday);
            this.panel1.Controls.Add(this.comb_education);
            this.panel1.Controls.Add(this.lbl_emp_education);
            this.panel1.Controls.Add(this.lbl_emp_phone);
            this.panel1.Controls.Add(this.cmb_position);
            this.panel1.Controls.Add(this.lbl_emp_posititon);
            this.panel1.Controls.Add(this.lbl_emp_address);
            this.panel1.Controls.Add(this.lbl1_emp_id);
            this.panel1.Location = new System.Drawing.Point(16, 140);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 388);
            this.panel1.TabIndex = 16;
            // 
            // comb_emp_gender
            // 
            this.comb_emp_gender.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_emp_gender.FormattingEnabled = true;
            this.comb_emp_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comb_emp_gender.Location = new System.Drawing.Point(597, 207);
            this.comb_emp_gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comb_emp_gender.Name = "comb_emp_gender";
            this.comb_emp_gender.Size = new System.Drawing.Size(188, 30);
            this.comb_emp_gender.TabIndex = 35;
            // 
            // txt_emp_gender
            // 
            this.txt_emp_gender.AutoSize = true;
            this.txt_emp_gender.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_gender.ForeColor = System.Drawing.Color.Red;
            this.txt_emp_gender.Location = new System.Drawing.Point(591, 145);
            this.txt_emp_gender.Name = "txt_emp_gender";
            this.txt_emp_gender.Size = new System.Drawing.Size(188, 31);
            this.txt_emp_gender.TabIndex = 34;
            this.txt_emp_gender.Text = "Employee Gender";
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_name.Location = new System.Drawing.Point(299, 76);
            this.txt_emp_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emp_name.Multiline = true;
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.Size = new System.Drawing.Size(188, 32);
            this.txt_emp_name.TabIndex = 33;
            // 
            // lbl_emp_name
            // 
            this.lbl_emp_name.AutoSize = true;
            this.lbl_emp_name.Font = new System.Drawing.Font("Gobold Thin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_emp_name.Location = new System.Drawing.Point(293, 25);
            this.lbl_emp_name.Name = "lbl_emp_name";
            this.lbl_emp_name.Size = new System.Drawing.Size(167, 31);
            this.lbl_emp_name.TabIndex = 32;
            this.lbl_emp_name.Text = "Employee Name";
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Gobold Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(27, 329);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_phone.Multiline = true;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(188, 32);
            this.txt_phone.TabIndex = 31;
            // 
            // txt_emp_address
            // 
            this.txt_emp_address.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_address.Location = new System.Drawing.Point(586, 76);
            this.txt_emp_address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emp_address.Multiline = true;
            this.txt_emp_address.Name = "txt_emp_address";
            this.txt_emp_address.Size = new System.Drawing.Size(175, 32);
            this.txt_emp_address.TabIndex = 30;
            // 
            // txt_emp_ID
            // 
            this.txt_emp_ID.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_ID.Location = new System.Drawing.Point(27, 76);
            this.txt_emp_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emp_ID.Multiline = true;
            this.txt_emp_ID.Name = "txt_emp_ID";
            this.txt_emp_ID.Size = new System.Drawing.Size(188, 32);
            this.txt_emp_ID.TabIndex = 29;
            // 
            // datetime_DOB
            // 
            this.datetime_DOB.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_DOB.Location = new System.Drawing.Point(308, 327);
            this.datetime_DOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datetime_DOB.Name = "datetime_DOB";
            this.datetime_DOB.Size = new System.Drawing.Size(188, 29);
            this.datetime_DOB.TabIndex = 28;
            // 
            // lbl_emp_Bday
            // 
            this.lbl_emp_Bday.AutoSize = true;
            this.lbl_emp_Bday.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_Bday.ForeColor = System.Drawing.Color.Red;
            this.lbl_emp_Bday.Location = new System.Drawing.Point(302, 270);
            this.lbl_emp_Bday.Name = "lbl_emp_Bday";
            this.lbl_emp_Bday.Size = new System.Drawing.Size(205, 31);
            this.lbl_emp_Bday.TabIndex = 27;
            this.lbl_emp_Bday.Text = "Employee BirthDay";
            // 
            // comb_education
            // 
            this.comb_education.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_education.FormattingEnabled = true;
            this.comb_education.Items.AddRange(new object[] {
            "B Tech",
            "M Tech",
            "BBA",
            "MBA",
            "Bcom"});
            this.comb_education.Location = new System.Drawing.Point(299, 207);
            this.comb_education.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comb_education.Name = "comb_education";
            this.comb_education.Size = new System.Drawing.Size(188, 30);
            this.comb_education.TabIndex = 26;
            // 
            // lbl_emp_education
            // 
            this.lbl_emp_education.AutoSize = true;
            this.lbl_emp_education.Font = new System.Drawing.Font("Gobold Thin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_education.ForeColor = System.Drawing.Color.Red;
            this.lbl_emp_education.Location = new System.Drawing.Point(293, 145);
            this.lbl_emp_education.Name = "lbl_emp_education";
            this.lbl_emp_education.Size = new System.Drawing.Size(214, 31);
            this.lbl_emp_education.TabIndex = 25;
            this.lbl_emp_education.Text = "Employee Education";
            // 
            // lbl_emp_phone
            // 
            this.lbl_emp_phone.AutoSize = true;
            this.lbl_emp_phone.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_phone.ForeColor = System.Drawing.Color.Red;
            this.lbl_emp_phone.Location = new System.Drawing.Point(24, 270);
            this.lbl_emp_phone.Name = "lbl_emp_phone";
            this.lbl_emp_phone.Size = new System.Drawing.Size(178, 31);
            this.lbl_emp_phone.TabIndex = 24;
            this.lbl_emp_phone.Text = "Employee Phone";
            // 
            // cmb_position
            // 
            this.cmb_position.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_position.FormattingEnabled = true;
            this.cmb_position.Items.AddRange(new object[] {
            "MANAGER",
            "SENIOR DEVELOPPER",
            "JUNIOR DEVELOPPER",
            "ACCOUNTATNT",
            "RECEPTIONIST"});
            this.cmb_position.Location = new System.Drawing.Point(27, 207);
            this.cmb_position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(188, 30);
            this.cmb_position.TabIndex = 23;
            // 
            // lbl_emp_posititon
            // 
            this.lbl_emp_posititon.AutoSize = true;
            this.lbl_emp_posititon.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_posititon.ForeColor = System.Drawing.Color.Red;
            this.lbl_emp_posititon.Location = new System.Drawing.Point(21, 145);
            this.lbl_emp_posititon.Name = "lbl_emp_posititon";
            this.lbl_emp_posititon.Size = new System.Drawing.Size(201, 31);
            this.lbl_emp_posititon.TabIndex = 22;
            this.lbl_emp_posititon.Text = "Employee Position";
            // 
            // lbl_emp_address
            // 
            this.lbl_emp_address.AutoSize = true;
            this.lbl_emp_address.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_address.ForeColor = System.Drawing.Color.Red;
            this.lbl_emp_address.Location = new System.Drawing.Point(580, 25);
            this.lbl_emp_address.Name = "lbl_emp_address";
            this.lbl_emp_address.Size = new System.Drawing.Size(199, 31);
            this.lbl_emp_address.TabIndex = 21;
            this.lbl_emp_address.Text = "Employee Address";
            // 
            // lbl1_emp_id
            // 
            this.lbl1_emp_id.AutoSize = true;
            this.lbl1_emp_id.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_emp_id.ForeColor = System.Drawing.Color.Red;
            this.lbl1_emp_id.Location = new System.Drawing.Point(21, 25);
            this.lbl1_emp_id.Name = "lbl1_emp_id";
            this.lbl1_emp_id.Size = new System.Drawing.Size(135, 31);
            this.lbl1_emp_id.TabIndex = 20;
            this.lbl1_emp_id.Text = "Employee ID";
            // 
            // btn_emp_add
            // 
            this.btn_emp_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_emp_add.Font = new System.Drawing.Font("Gobold Thin Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emp_add.Location = new System.Drawing.Point(841, 140);
            this.btn_emp_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_emp_add.Name = "btn_emp_add";
            this.btn_emp_add.Size = new System.Drawing.Size(165, 50);
            this.btn_emp_add.TabIndex = 32;
            this.btn_emp_add.Text = "Add";
            this.btn_emp_add.UseVisualStyleBackColor = false;
            this.btn_emp_add.Click += new System.EventHandler(this.btn_emp_add_Click);
            // 
            // pictureBox_emp
            // 
            this.pictureBox_emp.Image = global::salary_management_system.Properties.Resources.WhatsApp_Image_2021_05_05_at_10_31_38__1_;
            this.pictureBox_emp.Location = new System.Drawing.Point(36, 13);
            this.pictureBox_emp.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_emp.Name = "pictureBox_emp";
            this.pictureBox_emp.Size = new System.Drawing.Size(113, 96);
            this.pictureBox_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_emp.TabIndex = 15;
            this.pictureBox_emp.TabStop = false;
            // 
            // btn_emp_manage_view
            // 
            this.btn_emp_manage_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_emp_manage_view.Font = new System.Drawing.Font("Gobold Thin Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emp_manage_view.Location = new System.Drawing.Point(841, 478);
            this.btn_emp_manage_view.Margin = new System.Windows.Forms.Padding(4);
            this.btn_emp_manage_view.Name = "btn_emp_manage_view";
            this.btn_emp_manage_view.Size = new System.Drawing.Size(165, 50);
            this.btn_emp_manage_view.TabIndex = 34;
            this.btn_emp_manage_view.Text = "View";
            this.btn_emp_manage_view.UseVisualStyleBackColor = false;
            this.btn_emp_manage_view.Click += new System.EventHandler(this.btn_emp_manage_view_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.Font = new System.Drawing.Font("Gobold Thin Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(841, 255);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(165, 50);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // DGVUpdatedetails
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Gobold Thin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.DGVUpdatedetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVUpdatedetails.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVUpdatedetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVUpdatedetails.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGVUpdatedetails.GridColor = System.Drawing.Color.Gray;
            this.DGVUpdatedetails.Location = new System.Drawing.Point(16, 565);
            this.DGVUpdatedetails.Name = "DGVUpdatedetails";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVUpdatedetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGVUpdatedetails.RowHeadersWidth = 51;
            this.DGVUpdatedetails.RowTemplate.Height = 24;
            this.DGVUpdatedetails.Size = new System.Drawing.Size(1111, 313);
            this.DGVUpdatedetails.TabIndex = 36;
            this.DGVUpdatedetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUpdatedetails_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Font = new System.Drawing.Font("Gobold Thin Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(841, 368);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 50);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1076, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Image = global::salary_management_system.Properties.Resources.WhatsApp_Image_2021_05_05_at_10_31_38__2_;
            this.pictureBox_home.Location = new System.Drawing.Point(1000, 13);
            this.pictureBox_home.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(52, 52);
            this.pictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_home.TabIndex = 77;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // Employee_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1139, 930);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.DGVUpdatedetails);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btn_emp_manage_view);
            this.Controls.Add(this.btn_emp_add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_emp);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee_manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_manage";
            this.Load += new System.EventHandler(this.Employee_manage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUpdatedetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pictureBox_emp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_emp_address;
        private System.Windows.Forms.TextBox txt_emp_ID;
        private System.Windows.Forms.DateTimePicker datetime_DOB;
        private System.Windows.Forms.Label lbl_emp_Bday;
        private System.Windows.Forms.ComboBox comb_education;
        private System.Windows.Forms.Label lbl_emp_education;
        private System.Windows.Forms.Label lbl_emp_phone;
        private System.Windows.Forms.ComboBox cmb_position;
        private System.Windows.Forms.Label lbl_emp_posititon;
        private System.Windows.Forms.Label lbl_emp_address;
        private System.Windows.Forms.Label lbl1_emp_id;
        private System.Windows.Forms.Button btn_emp_add;
        private System.Windows.Forms.Button btn_emp_manage_view;
        private System.Windows.Forms.TextBox txt_emp_name;
        private System.Windows.Forms.Label lbl_emp_name;
        private System.Windows.Forms.ComboBox comb_emp_gender;
        private System.Windows.Forms.Label txt_emp_gender;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView DGVUpdatedetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_home;
    }
}