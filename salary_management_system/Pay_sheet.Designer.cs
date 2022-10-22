
namespace salary_management_system
{
    partial class Pay_sheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay_sheet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comb_pay_month = new System.Windows.Forms.ComboBox();
            this.txt_paymonth = new System.Windows.Forms.Label();
            this.lblpaymonth = new System.Windows.Forms.Label();
            this.lblpayid = new System.Windows.Forms.Label();
            this.lblsal = new System.Windows.Forms.Label();
            this.lblwrkdays = new System.Windows.Forms.Label();
            this.lblEmpname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lbl1_emp_id = new System.Windows.Forms.Label();
            this.txt_emp_ID = new System.Windows.Forms.TextBox();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.lblpaysheet = new System.Windows.Forms.Label();
            this.pictureBox_emp = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comb_pay_month);
            this.panel1.Controls.Add(this.txt_paymonth);
            this.panel1.Controls.Add(this.lblpaymonth);
            this.panel1.Controls.Add(this.lblpayid);
            this.panel1.Controls.Add(this.lblsal);
            this.panel1.Controls.Add(this.lblwrkdays);
            this.panel1.Controls.Add(this.lblEmpname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.lbl1_emp_id);
            this.panel1.Controls.Add(this.txt_emp_ID);
            this.panel1.Location = new System.Drawing.Point(3, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 375);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comb_pay_month
            // 
            this.comb_pay_month.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_pay_month.FormattingEnabled = true;
            this.comb_pay_month.Items.AddRange(new object[] {
            "2021 JANUARY",
            "2021 FEBRUARY",
            "2021 MARCH",
            "2021 APRIL",
            "2021 MAY",
            "2021 JUNE",
            "2021 JULY",
            "2021 AUGUST",
            "2021 SEPTEMBER",
            "2021 OCTOBER",
            "2021 NOVEMBER",
            "2021 DECEMBER"});
            this.comb_pay_month.Location = new System.Drawing.Point(513, 62);
            this.comb_pay_month.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comb_pay_month.Name = "comb_pay_month";
            this.comb_pay_month.Size = new System.Drawing.Size(188, 30);
            this.comb_pay_month.TabIndex = 99;
            // 
            // txt_paymonth
            // 
            this.txt_paymonth.AutoSize = true;
            this.txt_paymonth.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymonth.ForeColor = System.Drawing.Color.Red;
            this.txt_paymonth.Location = new System.Drawing.Point(507, 27);
            this.txt_paymonth.Name = "txt_paymonth";
            this.txt_paymonth.Size = new System.Drawing.Size(173, 31);
            this.txt_paymonth.TabIndex = 98;
            this.txt_paymonth.Text = "payment month";
            // 
            // lblpaymonth
            // 
            this.lblpaymonth.AutoSize = true;
            this.lblpaymonth.Font = new System.Drawing.Font("Gobold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaymonth.ForeColor = System.Drawing.Color.Navy;
            this.lblpaymonth.Location = new System.Drawing.Point(507, 212);
            this.lblpaymonth.Name = "lblpaymonth";
            this.lblpaymonth.Size = new System.Drawing.Size(200, 36);
            this.lblpaymonth.TabIndex = 95;
            this.lblpaymonth.Text = "payment month";
            // 
            // lblpayid
            // 
            this.lblpayid.AutoSize = true;
            this.lblpayid.Font = new System.Drawing.Font("Gobold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayid.ForeColor = System.Drawing.Color.Navy;
            this.lblpayid.Location = new System.Drawing.Point(507, 103);
            this.lblpayid.Name = "lblpayid";
            this.lblpayid.Size = new System.Drawing.Size(146, 36);
            this.lblpayid.TabIndex = 94;
            this.lblpayid.Text = "payment ID";
            // 
            // lblsal
            // 
            this.lblsal.AutoSize = true;
            this.lblsal.Font = new System.Drawing.Font("Gobold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsal.ForeColor = System.Drawing.Color.Navy;
            this.lblsal.Location = new System.Drawing.Point(507, 319);
            this.lblsal.Name = "lblsal";
            this.lblsal.Size = new System.Drawing.Size(218, 36);
            this.lblsal.TabIndex = 93;
            this.lblsal.Text = "Employee salary";
            // 
            // lblwrkdays
            // 
            this.lblwrkdays.AutoSize = true;
            this.lblwrkdays.Font = new System.Drawing.Font("Gobold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwrkdays.ForeColor = System.Drawing.Color.Navy;
            this.lblwrkdays.Location = new System.Drawing.Point(507, 266);
            this.lblwrkdays.Name = "lblwrkdays";
            this.lblwrkdays.Size = new System.Drawing.Size(265, 36);
            this.lblwrkdays.TabIndex = 92;
            this.lblwrkdays.Text = "Employee Work Days";
            // 
            // lblEmpname
            // 
            this.lblEmpname.AutoSize = true;
            this.lblEmpname.Font = new System.Drawing.Font("Gobold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpname.ForeColor = System.Drawing.Color.Navy;
            this.lblEmpname.Location = new System.Drawing.Point(507, 156);
            this.lblEmpname.Name = "lblEmpname";
            this.lblEmpname.Size = new System.Drawing.Size(158, 36);
            this.lblEmpname.TabIndex = 91;
            this.lblEmpname.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gobold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(29, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 36);
            this.label1.TabIndex = 90;
            this.label1.Text = "payment month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gobold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(29, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 36);
            this.label2.TabIndex = 89;
            this.label2.Text = "payment ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gobold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(29, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 36);
            this.label3.TabIndex = 88;
            this.label3.Text = "Employee salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gobold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(29, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 36);
            this.label4.TabIndex = 87;
            this.label4.Text = "Employee Work Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gobold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(29, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 36);
            this.label5.TabIndex = 86;
            this.label5.Text = "Employee ID";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Red;
            this.btnShow.Font = new System.Drawing.Font("Gobold Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(827, 174);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(165, 50);
            this.btnShow.TabIndex = 77;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lbl1_emp_id
            // 
            this.lbl1_emp_id.AutoSize = true;
            this.lbl1_emp_id.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_emp_id.ForeColor = System.Drawing.Color.Red;
            this.lbl1_emp_id.Location = new System.Drawing.Point(31, 27);
            this.lbl1_emp_id.Name = "lbl1_emp_id";
            this.lbl1_emp_id.Size = new System.Drawing.Size(135, 31);
            this.lbl1_emp_id.TabIndex = 78;
            this.lbl1_emp_id.Text = "Employee ID";
            // 
            // txt_emp_ID
            // 
            this.txt_emp_ID.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_ID.Location = new System.Drawing.Point(37, 62);
            this.txt_emp_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emp_ID.Multiline = true;
            this.txt_emp_ID.Name = "txt_emp_ID";
            this.txt_emp_ID.Size = new System.Drawing.Size(188, 32);
            this.txt_emp_ID.TabIndex = 79;
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Image = global::salary_management_system.Properties.Resources.WhatsApp_Image_2021_05_05_at_10_31_38__2_;
            this.pictureBox_home.Location = new System.Drawing.Point(1021, 13);
            this.pictureBox_home.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(59, 49);
            this.pictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_home.TabIndex = 76;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // lblpaysheet
            // 
            this.lblpaysheet.AutoSize = true;
            this.lblpaysheet.Font = new System.Drawing.Font("Gobold Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaysheet.ForeColor = System.Drawing.Color.DarkGray;
            this.lblpaysheet.Location = new System.Drawing.Point(127, 42);
            this.lblpaysheet.Name = "lblpaysheet";
            this.lblpaysheet.Size = new System.Drawing.Size(303, 43);
            this.lblpaysheet.TabIndex = 78;
            this.lblpaysheet.Text = "Employee PaySheet";
            // 
            // pictureBox_emp
            // 
            this.pictureBox_emp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_emp.Image")));
            this.pictureBox_emp.Location = new System.Drawing.Point(13, 19);
            this.pictureBox_emp.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_emp.Name = "pictureBox_emp";
            this.pictureBox_emp.Size = new System.Drawing.Size(90, 89);
            this.pictureBox_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_emp.TabIndex = 77;
            this.pictureBox_emp.TabStop = false;
            // 
            // Pay_sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1093, 587);
            this.Controls.Add(this.lblpaysheet);
            this.Controls.Add(this.pictureBox_emp);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pay_sheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay_sheet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lbl1_emp_id;
        private System.Windows.Forms.TextBox txt_emp_ID;
        private System.Windows.Forms.Label lblpaymonth;
        private System.Windows.Forms.Label lblpayid;
        private System.Windows.Forms.Label lblsal;
        private System.Windows.Forms.Label lblwrkdays;
        private System.Windows.Forms.Label lblEmpname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comb_pay_month;
        private System.Windows.Forms.Label txt_paymonth;
        private System.Windows.Forms.Label lblpaysheet;
        private System.Windows.Forms.PictureBox pictureBox_emp;
    }
}