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
    public partial class Check_Pwd : Form
    {
        public Check_Pwd()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Add_msg s1 = new Add_msg();
            s1.Show();
            this.Hide();
        }

        private void btn_splash_continue_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {

            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_user_ID.Text = "";
            txt_password.Text = "";
        }
    }
}
