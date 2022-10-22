
namespace salary_management_system
{
    partial class MessageBox_Login
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
            this.cmb_position = new System.Windows.Forms.ComboBox();
            this.lbl_emp_posititon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_splash_continue
            // 
            this.btn_splash_continue.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_splash_continue.Font = new System.Drawing.Font("Gobold Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_splash_continue.Location = new System.Drawing.Point(420, 333);
            this.btn_splash_continue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_splash_continue.Name = "btn_splash_continue";
            this.btn_splash_continue.Size = new System.Drawing.Size(239, 57);
            this.btn_splash_continue.TabIndex = 37;
            this.btn_splash_continue.Text = "Continue";
            this.btn_splash_continue.UseVisualStyleBackColor = false;
            this.btn_splash_continue.Click += new System.EventHandler(this.btn_splash_continue_Click);
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
            this.cmb_position.Location = new System.Drawing.Point(445, 219);
            this.cmb_position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(188, 30);
            this.cmb_position.TabIndex = 36;
            // 
            // lbl_emp_posititon
            // 
            this.lbl_emp_posititon.AutoSize = true;
            this.lbl_emp_posititon.Font = new System.Drawing.Font("Gobold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_posititon.ForeColor = System.Drawing.Color.Red;
            this.lbl_emp_posititon.Location = new System.Drawing.Point(439, 171);
            this.lbl_emp_posititon.Name = "lbl_emp_posititon";
            this.lbl_emp_posititon.Size = new System.Drawing.Size(201, 31);
            this.lbl_emp_posititon.TabIndex = 35;
            this.lbl_emp_posititon.Text = "Employee Position";
            // 
            // MessageBox_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1094, 565);
            this.Controls.Add(this.btn_splash_continue);
            this.Controls.Add(this.cmb_position);
            this.Controls.Add(this.lbl_emp_posititon);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBox_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_splash_continue;
        private System.Windows.Forms.ComboBox cmb_position;
        private System.Windows.Forms.Label lbl_emp_posititon;
    }
}