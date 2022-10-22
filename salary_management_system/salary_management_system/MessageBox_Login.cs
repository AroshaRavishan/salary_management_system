using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salary_management_system
{
    public partial class MessageBox_Login : Form
    {
        public MessageBox_Login()
        {
            InitializeComponent();
        }

        private void btn_splash_continue_Click(object sender, EventArgs e)
        {
            if (cmb_position.Text == "MANAGER")
            {
                CheckPwdMessage_box l1 = new CheckPwdMessage_box();
                l1.Show();
                this.Hide();
            }
            else if (cmb_position.Text == "DIRECTOR")
            {
                CheckPwdMessage_box l1 = new CheckPwdMessage_box();
                l1.Show();
                this.Hide();
            }
            else if (cmb_position.Text == "SENIOR DEVELOPPER")
            {

                Without_Login_Message l1 = new Without_Login_Message();
                l1.Show();
                this.Hide();
            }
            else if (cmb_position.Text == "JUNIOR DEVELOPPER")
            {

                Without_Login_Message l1 = new Without_Login_Message();
                l1.Show();
                this.Hide();
            }

            else if (cmb_position.Text == "ACCOUNTATNT")
            {

                Without_Login_Message l1 = new Without_Login_Message();
                l1.Show();
                this.Hide();
            }
            else if (cmb_position.Text == "RECEPTIONIST")
            {

                Without_Login_Message l1 = new Without_Login_Message();
                l1.Show();
                this.Hide();
            }
        }
    }
}
