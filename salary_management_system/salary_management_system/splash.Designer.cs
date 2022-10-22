
namespace salary_management_system
{
    partial class splash
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
            this.lblHeadingManagment = new System.Windows.Forms.Label();
            this.pictureBox_emp = new System.Windows.Forms.PictureBox();
            this.btn_splash_continue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeadingManagment
            // 
            this.lblHeadingManagment.AutoSize = true;
            this.lblHeadingManagment.Font = new System.Drawing.Font("Gobold CUTS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingManagment.ForeColor = System.Drawing.Color.Blue;
            this.lblHeadingManagment.Location = new System.Drawing.Point(264, 46);
            this.lblHeadingManagment.Name = "lblHeadingManagment";
            this.lblHeadingManagment.Size = new System.Drawing.Size(579, 52);
            this.lblHeadingManagment.TabIndex = 1;
            this.lblHeadingManagment.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            // 
            // pictureBox_emp
            // 
            this.pictureBox_emp.Image = global::salary_management_system.Properties.Resources.WhatsApp_Image_2021_05_05_at_10_31_35__1_;
            this.pictureBox_emp.Location = new System.Drawing.Point(409, 143);
            this.pictureBox_emp.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_emp.Name = "pictureBox_emp";
            this.pictureBox_emp.Size = new System.Drawing.Size(239, 203);
            this.pictureBox_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_emp.TabIndex = 16;
            this.pictureBox_emp.TabStop = false;
            this.pictureBox_emp.Click += new System.EventHandler(this.pictureBox_emp_Click);
            // 
            // btn_splash_continue
            // 
            this.btn_splash_continue.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_splash_continue.Font = new System.Drawing.Font("Gobold Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_splash_continue.Location = new System.Drawing.Point(409, 423);
            this.btn_splash_continue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_splash_continue.Name = "btn_splash_continue";
            this.btn_splash_continue.Size = new System.Drawing.Size(239, 57);
            this.btn_splash_continue.TabIndex = 33;
            this.btn_splash_continue.Text = "Continue";
            this.btn_splash_continue.UseVisualStyleBackColor = false;
            this.btn_splash_continue.Click += new System.EventHandler(this.btn_splash_continue_Click);
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_splash_continue);
            this.Controls.Add(this.pictureBox_emp);
            this.Controls.Add(this.lblHeadingManagment);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadingManagment;
        private System.Windows.Forms.PictureBox pictureBox_emp;
        private System.Windows.Forms.Button btn_splash_continue;
    }
}