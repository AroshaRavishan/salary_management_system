
namespace salary_management_system
{
    partial class Employee_attendance1
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
            this.cmb_position = new System.Windows.Forms.ComboBox();
            this.lbl_emp_posititon = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.DGVATtendance = new System.Windows.Forms.DataGridView();
            this.txt_emp_name = new System.Windows.Forms.TextBox();
            this.lbl1_emp_id = new System.Windows.Forms.Label();
            this.lbl_emp_name = new System.Windows.Forms.Label();
            this.txt_emp_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVATtendance)).BeginInit();
            this.SuspendLayout();
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
            this.cmb_position.Location = new System.Drawing.Point(250, 99);
            this.cmb_position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(188, 30);
            this.cmb_position.TabIndex = 25;
            // 
            // lbl_emp_posititon
            // 
            this.lbl_emp_posititon.AutoSize = true;
            this.lbl_emp_posititon.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_posititon.ForeColor = System.Drawing.Color.Red;
            this.lbl_emp_posititon.Location = new System.Drawing.Point(26, 99);
            this.lbl_emp_posititon.Name = "lbl_emp_posititon";
            this.lbl_emp_posititon.Size = new System.Drawing.Size(201, 31);
            this.lbl_emp_posititon.TabIndex = 24;
            this.lbl_emp_posititon.Text = "Employee Position";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Red;
            this.btnShow.Font = new System.Drawing.Font("Gobold Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(475, 87);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(165, 50);
            this.btnShow.TabIndex = 45;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // DGVATtendance
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Gobold Thin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.DGVATtendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVATtendance.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVATtendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVATtendance.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGVATtendance.GridColor = System.Drawing.Color.Gray;
            this.DGVATtendance.Location = new System.Drawing.Point(32, 159);
            this.DGVATtendance.Name = "DGVATtendance";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVATtendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGVATtendance.RowHeadersWidth = 51;
            this.DGVATtendance.RowTemplate.Height = 24;
            this.DGVATtendance.Size = new System.Drawing.Size(1016, 279);
            this.DGVATtendance.TabIndex = 46;
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_name.Location = new System.Drawing.Point(761, 515);
            this.txt_emp_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emp_name.Multiline = true;
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.Size = new System.Drawing.Size(188, 32);
            this.txt_emp_name.TabIndex = 50;
            // 
            // lbl1_emp_id
            // 
            this.lbl1_emp_id.AutoSize = true;
            this.lbl1_emp_id.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1_emp_id.ForeColor = System.Drawing.Color.Red;
            this.lbl1_emp_id.Location = new System.Drawing.Point(558, 480);
            this.lbl1_emp_id.Name = "lbl1_emp_id";
            this.lbl1_emp_id.Size = new System.Drawing.Size(135, 31);
            this.lbl1_emp_id.TabIndex = 47;
            this.lbl1_emp_id.Text = "Employee ID";
            // 
            // lbl_emp_name
            // 
            this.lbl_emp_name.AutoSize = true;
            this.lbl_emp_name.Font = new System.Drawing.Font("Gobold Thin", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_emp_name.Location = new System.Drawing.Point(771, 480);
            this.lbl_emp_name.Name = "lbl_emp_name";
            this.lbl_emp_name.Size = new System.Drawing.Size(167, 31);
            this.lbl_emp_name.TabIndex = 49;
            this.lbl_emp_name.Text = "Employee Name";
            // 
            // txt_emp_ID
            // 
            this.txt_emp_ID.Font = new System.Drawing.Font("Gobold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_ID.Location = new System.Drawing.Point(534, 515);
            this.txt_emp_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_emp_ID.Multiline = true;
            this.txt_emp_ID.Name = "txt_emp_ID";
            this.txt_emp_ID.Size = new System.Drawing.Size(188, 32);
            this.txt_emp_ID.TabIndex = 48;
            // 
            // Employee_attendance1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1073, 594);
            this.Controls.Add(this.txt_emp_name);
            this.Controls.Add(this.lbl1_emp_id);
            this.Controls.Add(this.lbl_emp_name);
            this.Controls.Add(this.txt_emp_ID);
            this.Controls.Add(this.DGVATtendance);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cmb_position);
            this.Controls.Add(this.lbl_emp_posititon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee_attendance1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_attendance1";
            this.Load += new System.EventHandler(this.Employee_attendance1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVATtendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_position;
        private System.Windows.Forms.Label lbl_emp_posititon;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView DGVATtendance;
        private System.Windows.Forms.TextBox txt_emp_name;
        private System.Windows.Forms.Label lbl1_emp_id;
        private System.Windows.Forms.Label lbl_emp_name;
        private System.Windows.Forms.TextBox txt_emp_ID;
    }
}