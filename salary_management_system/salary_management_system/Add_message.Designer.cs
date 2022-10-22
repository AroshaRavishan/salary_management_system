
namespace salary_management_system
{
    partial class Add_message
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
            this.btnSave_Msg = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave_Msg
            // 
            this.btnSave_Msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave_Msg.Font = new System.Drawing.Font("Gobold Thin Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_Msg.Location = new System.Drawing.Point(361, 217);
            this.btnSave_Msg.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave_Msg.Name = "btnSave_Msg";
            this.btnSave_Msg.Size = new System.Drawing.Size(176, 108);
            this.btnSave_Msg.TabIndex = 37;
            this.btnSave_Msg.Text = "Save Meesage";
            this.btnSave_Msg.UseVisualStyleBackColor = false;
            this.btnSave_Msg.Click += new System.EventHandler(this.btnSave_Msg_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(681, 263);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 17);
            this.lblmsg.TabIndex = 38;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(631, 322);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(100, 22);
            this.txtMsg.TabIndex = 40;
            // 
            // Add_message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1093, 561);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnSave_Msg);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave_Msg;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.TextBox txtMsg;
    }
}