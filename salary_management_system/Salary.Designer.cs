
namespace salary_management_system
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.lblSalary = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comb_pay_month = new System.Windows.Forms.ComboBox();
            this.txt_paymonth = new System.Windows.Forms.Label();
            this.lblpayid = new System.Windows.Forms.Label();
            this.txtpayid = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOt_hours = new System.Windows.Forms.Label();
            this.txt_ot_Hours = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_emp_salary = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.btn_emp_manage_view = new System.Windows.Forms.Button();
            this.btn_emp_Data = new System.Windows.Forms.Button();
            this.lbl_emp_workeddays = new System.Windows.Forms.Label();
            this.txtEmp_workeddays = new System.Windows.Forms.TextBox();
            this.txt_emp_name = new System.Windows.Forms.TextBox();
            this.lbl1_emp_id = new System.Windows.Forms.Label();
            this.lbl_emp_name = new System.Windows.Forms.Label();
            this.lbl_emp_posititon = new System.Windows.Forms.Label();
            this.txt_emp_ID = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox_salary = new System.Windows.Forms.PictureBox();
            this.pictureBox_home = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Gobold Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSalary.Location = new System.Drawing.Point(160, 41);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(151, 52);
            this.lblSalary.TabIndex = 9;
            this.lblSalary.Text = "SALARY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comb_pay_month);
            this.panel1.Controls.Add(this.txt_paymonth);
            this.panel1.Controls.Add(this.lblpayid);
            this.panel1.Controls.Add(this.txtpayid);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.lblOt_hours);
            this.panel1.Controls.Add(this.txt_ot_Hours);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_emp_salary);
            this.panel1.Controls.Add(this.txtsalary);
            this.panel1.Controls.Add(this.txtPos);
            this.panel1.Controls.Add(this.btn_emp_manage_view);
            this.panel1.Controls.Add(this.btn_emp_Data);
            this.panel1.Controls.Add(this.lbl_emp_workeddays);
            this.panel1.Controls.Add(this.txtEmp_workeddays);
            this.panel1.Controls.Add(this.txt_emp_name);
            this.panel1.Controls.Add(this.lbl1_emp_id);
            this.panel1.Controls.Add(this.lbl_emp_name);
            this.panel1.Controls.Add(this.lbl_emp_posititon);
            this.panel1.Controls.Add(this.txt_emp_ID);
            this.panel1.Location = new System.Drawing.Point(2, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 424);
            this.panel1.TabIndex = 35;
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
            "2021 DECEMBER",
            "2022 JANUARY",
            "2022 FEBRUARY",
            "2022 MARCH",
            "2022 APRIL",
            "2022 MAY",
            "2022 JUNE",
            "2022 JULY",
            "2022 AUGUST",
            "2022 SEPTEMBER",
            "2022 OCTOBER",
            "2022 NOVEMBER",
            "2022 DECEMBER"});
            this.comb_pay_month.Location = new System.Drawing.Point(599, 58);
            this.comb_pay_month.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comb_pay_month.Name = "comb_pay_month";
            this.comb_pay_month.Size = new System.Drawing.Size(188, 30);
            this.comb_pay_month.TabIndex = 59;
            // 
            // txt_paymonth
            // 
            this.txt_paymonth.AutoSize = true;
            this.txt_paymonth.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymonth.ForeColor = System.Drawing.Color.Red;
            this.txt_paymonth.Location = new System.Drawing.Point(593, 18);
            this.txt_paymonth.Name = "txt_paymonth";
            this.txt_paymonth.Size = new System.Drawing.Size(173, 31);
            this.txt_paymonth.TabIndex = 58;
            this.txt_paymonth.Text = "payment month";
            // 
            // lblpayid
            // 
            this.lblpayid.AutoSize = true;
            this.lblpayid.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayid.ForeColor = System.Drawing.Color.Red;
            this.lblpayid.Location = new System.Drawing.Point(301, 18);
            this.lblpayid.Name = "lblpayid";
            this.lblpayid.Size = new System.Drawing.Size(176, 31);
            this.lblpayid.TabIndex = 56;
            this.lblpayid.Text = "Employee pay id";
            // 
            // txtpayid
            // 
            this.txtpayid.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpayid.Location = new System.Drawing.Point(307, 53);
            this.txtpayid.Margin = new System.Windows.Forms.Padding(4);
            this.txtpayid.Multiline = true;
            this.txtpayid.Name = "txtpayid";
            this.txtpayid.Size = new System.Drawing.Size(188, 32);
            this.txtpayid.TabIndex = 57;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrint.Font = new System.Drawing.Font("Gobold Thin Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(789, 358);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(165, 50);
            this.btnPrint.TabIndex = 54;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.Font = new System.Drawing.Font("Gobold Thin Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(990, 358);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 50);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOt_hours
            // 
            this.lblOt_hours.AutoSize = true;
            this.lblOt_hours.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOt_hours.ForeColor = System.Drawing.Color.Red;
            this.lblOt_hours.Location = new System.Drawing.Point(593, 120);
            this.lblOt_hours.Name = "lblOt_hours";
            this.lblOt_hours.Size = new System.Drawing.Size(207, 31);
            this.lblOt_hours.TabIndex = 51;
            this.lblOt_hours.Text = "Employee Ot Hours";
            // 
            // txt_ot_Hours
            // 
            this.txt_ot_Hours.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ot_Hours.Location = new System.Drawing.Point(599, 155);
            this.txt_ot_Hours.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ot_Hours.Multiline = true;
            this.txt_ot_Hours.Name = "txt_ot_Hours";
            this.txt_ot_Hours.Size = new System.Drawing.Size(188, 32);
            this.txt_ot_Hours.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(858, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_emp_salary
            // 
            this.lbl_emp_salary.AutoSize = true;
            this.lbl_emp_salary.Font = new System.Drawing.Font("Gobold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_salary.ForeColor = System.Drawing.Color.Navy;
            this.lbl_emp_salary.Location = new System.Drawing.Point(410, 219);
            this.lbl_emp_salary.Name = "lbl_emp_salary";
            this.lbl_emp_salary.Size = new System.Drawing.Size(235, 39);
            this.lbl_emp_salary.TabIndex = 48;
            this.lbl_emp_salary.Text = "Employee Salary";
            // 
            // txtsalary
            // 
            this.txtsalary.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.Location = new System.Drawing.Point(417, 281);
            this.txtsalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtsalary.Multiline = true;
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(219, 32);
            this.txtsalary.TabIndex = 49;
            this.txtsalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPos
            // 
            this.txtPos.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPos.Location = new System.Drawing.Point(20, 272);
            this.txtPos.Margin = new System.Windows.Forms.Padding(4);
            this.txtPos.Multiline = true;
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(188, 32);
            this.txtPos.TabIndex = 47;
            // 
            // btn_emp_manage_view
            // 
            this.btn_emp_manage_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_emp_manage_view.Font = new System.Drawing.Font("Gobold Thin Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emp_manage_view.Location = new System.Drawing.Point(589, 358);
            this.btn_emp_manage_view.Margin = new System.Windows.Forms.Padding(4);
            this.btn_emp_manage_view.Name = "btn_emp_manage_view";
            this.btn_emp_manage_view.Size = new System.Drawing.Size(165, 50);
            this.btn_emp_manage_view.TabIndex = 37;
            this.btn_emp_manage_view.Text = "View";
            this.btn_emp_manage_view.UseVisualStyleBackColor = false;
            this.btn_emp_manage_view.Click += new System.EventHandler(this.btn_emp_manage_view_Click);
            // 
            // btn_emp_Data
            // 
            this.btn_emp_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_emp_Data.Font = new System.Drawing.Font("Gobold Thin Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emp_Data.Location = new System.Drawing.Point(391, 358);
            this.btn_emp_Data.Margin = new System.Windows.Forms.Padding(4);
            this.btn_emp_Data.Name = "btn_emp_Data";
            this.btn_emp_Data.Size = new System.Drawing.Size(165, 50);
            this.btn_emp_Data.TabIndex = 36;
            this.btn_emp_Data.Text = "Data";
            this.btn_emp_Data.UseVisualStyleBackColor = false;
            this.btn_emp_Data.Click += new System.EventHandler(this.btn_emp_manage_home_Click);
            // 
            // lbl_emp_workeddays
            // 
            this.lbl_emp_workeddays.AutoSize = true;
            this.lbl_emp_workeddays.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_workeddays.ForeColor = System.Drawing.Color.Red;
            this.lbl_emp_workeddays.Location = new System.Drawing.Point(301, 120);
            this.lbl_emp_workeddays.Name = "lbl_emp_workeddays";
            this.lbl_emp_workeddays.Size = new System.Drawing.Size(226, 31);
            this.lbl_emp_workeddays.TabIndex = 44;
            this.lbl_emp_workeddays.Text = "Employee Work Days";
            // 
            // txtEmp_workeddays
            // 
            this.txtEmp_workeddays.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmp_workeddays.Location = new System.Drawing.Point(307, 155);
            this.txtEmp_workeddays.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmp_workeddays.Multiline = true;
            this.txtEmp_workeddays.Name = "txtEmp_workeddays";
            this.txtEmp_workeddays.Size = new System.Drawing.Size(188, 32);
            this.txtEmp_workeddays.TabIndex = 45;
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_name.Location = new System.Drawing.Point(16, 155);
            this.txt_emp_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emp_name.Multiline = true;
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.Size = new System.Drawing.Size(188, 32);
            this.txt_emp_name.TabIndex = 43;
            // 
            // lbl1_emp_id
            // 
            this.lbl1_emp_id.AutoSize = true;
            this.lbl1_emp_id.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_emp_id.ForeColor = System.Drawing.Color.Red;
            this.lbl1_emp_id.Location = new System.Drawing.Point(14, 18);
            this.lbl1_emp_id.Name = "lbl1_emp_id";
            this.lbl1_emp_id.Size = new System.Drawing.Size(135, 31);
            this.lbl1_emp_id.TabIndex = 36;
            this.lbl1_emp_id.Text = "Employee ID";
            // 
            // lbl_emp_name
            // 
            this.lbl_emp_name.AutoSize = true;
            this.lbl_emp_name.Font = new System.Drawing.Font("Gobold Thin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_emp_name.Location = new System.Drawing.Point(10, 120);
            this.lbl_emp_name.Name = "lbl_emp_name";
            this.lbl_emp_name.Size = new System.Drawing.Size(167, 31);
            this.lbl_emp_name.TabIndex = 42;
            this.lbl_emp_name.Text = "Employee Name";
            // 
            // lbl_emp_posititon
            // 
            this.lbl_emp_posititon.AutoSize = true;
            this.lbl_emp_posititon.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_posititon.ForeColor = System.Drawing.Color.Red;
            this.lbl_emp_posititon.Location = new System.Drawing.Point(14, 227);
            this.lbl_emp_posititon.Name = "lbl_emp_posititon";
            this.lbl_emp_posititon.Size = new System.Drawing.Size(201, 31);
            this.lbl_emp_posititon.TabIndex = 37;
            this.lbl_emp_posititon.Text = "Employee Position";
            // 
            // txt_emp_ID
            // 
            this.txt_emp_ID.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_ID.Location = new System.Drawing.Point(20, 53);
            this.txt_emp_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emp_ID.Multiline = true;
            this.txt_emp_ID.Name = "txt_emp_ID";
            this.txt_emp_ID.Size = new System.Drawing.Size(188, 32);
            this.txt_emp_ID.TabIndex = 41;
            this.txt_emp_ID.TextChanged += new System.EventHandler(this.txt_emp_ID_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox_salary
            // 
            this.pictureBox_salary.Image = global::salary_management_system.Properties.Resources.WhatsApp_Image_2021_05_05_at_10_31_37;
            this.pictureBox_salary.Location = new System.Drawing.Point(22, 13);
            this.pictureBox_salary.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_salary.Name = "pictureBox_salary";
            this.pictureBox_salary.Size = new System.Drawing.Size(113, 96);
            this.pictureBox_salary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_salary.TabIndex = 14;
            this.pictureBox_salary.TabStop = false;
            // 
            // pictureBox_home
            // 
            this.pictureBox_home.Image = global::salary_management_system.Properties.Resources.WhatsApp_Image_2021_05_05_at_10_31_38__2_;
            this.pictureBox_home.Location = new System.Drawing.Point(1121, 13);
            this.pictureBox_home.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_home.Name = "pictureBox_home";
            this.pictureBox_home.Size = new System.Drawing.Size(59, 49);
            this.pictureBox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_home.TabIndex = 75;
            this.pictureBox_home.TabStop = false;
            this.pictureBox_home.Click += new System.EventHandler(this.pictureBox_home_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1193, 597);
            this.Controls.Add(this.pictureBox_home);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_salary);
            this.Controls.Add(this.lblSalary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.PictureBox pictureBox_salary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl1_emp_id;
        private System.Windows.Forms.Label lbl_emp_name;
        private System.Windows.Forms.Label lbl_emp_posititon;
        private System.Windows.Forms.TextBox txt_emp_ID;
        private System.Windows.Forms.Label lbl_emp_workeddays;
        private System.Windows.Forms.TextBox txtEmp_workeddays;
        private System.Windows.Forms.Button btn_emp_manage_view;
        private System.Windows.Forms.Button btn_emp_Data;
        private System.Windows.Forms.Label lbl_emp_salary;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOt_hours;
        private System.Windows.Forms.TextBox txt_ot_Hours;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.TextBox txt_emp_name;
        private System.Windows.Forms.PictureBox pictureBox_home;
        private System.Windows.Forms.Label lblpayid;
        private System.Windows.Forms.TextBox txtpayid;
        private System.Windows.Forms.ComboBox comb_pay_month;
        private System.Windows.Forms.Label txt_paymonth;
    }
}