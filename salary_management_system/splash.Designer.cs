
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            this.lblHeadingManagment = new System.Windows.Forms.Label();
            this.pictureBox_emp = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblvisible = new System.Windows.Forms.Label();
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
            this.pictureBox_emp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_emp.Image")));
            this.pictureBox_emp.Location = new System.Drawing.Point(334, 113);
            this.pictureBox_emp.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_emp.Name = "pictureBox_emp";
            this.pictureBox_emp.Size = new System.Drawing.Size(422, 276);
            this.pictureBox_emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_emp.TabIndex = 16;
            this.pictureBox_emp.TabStop = false;
            this.pictureBox_emp.Click += new System.EventHandler(this.pictureBox_emp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(100, 547);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 19);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Location = new System.Drawing.Point(100, 547);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 19);
            this.panel2.TabIndex = 35;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblvisible
            // 
            this.lblvisible.AutoSize = true;
            this.lblvisible.Font = new System.Drawing.Font("Gobold CUTS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvisible.ForeColor = System.Drawing.Color.Blue;
            this.lblvisible.Location = new System.Drawing.Point(95, 508);
            this.lblvisible.Name = "lblvisible";
            this.lblvisible.Size = new System.Drawing.Size(256, 27);
            this.lblvisible.TabIndex = 36;
            this.lblvisible.Text = "LOADING  PLEASE WAIT.......";
            // 
            // btn_splash_continue
            // 
            this.btn_splash_continue.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_splash_continue.Font = new System.Drawing.Font("Gobold Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_splash_continue.Location = new System.Drawing.Point(451, 397);
            this.btn_splash_continue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_splash_continue.Name = "btn_splash_continue";
            this.btn_splash_continue.Size = new System.Drawing.Size(181, 56);
            this.btn_splash_continue.TabIndex = 33;
            this.btn_splash_continue.Text = "Welcome";
            this.btn_splash_continue.UseVisualStyleBackColor = false;
            this.btn_splash_continue.Click += new System.EventHandler(this.btn_splash_continue_Click);
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.lblvisible);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_splash_continue);
            this.Controls.Add(this.pictureBox_emp);
            this.Controls.Add(this.lblHeadingManagment);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splash";
            this.Load += new System.EventHandler(this.splash_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeadingManagment;
        private System.Windows.Forms.PictureBox pictureBox_emp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblvisible;
        private System.Windows.Forms.Button btn_splash_continue;
    }
}