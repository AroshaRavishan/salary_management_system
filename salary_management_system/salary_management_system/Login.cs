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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if (txt_user_ID.Text == "ADMIN" && txt_password.Text == "1111")
            {
                Home ds = new Home();
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("your user name or Password Not Match Please try Agin");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home ds = new Home("Guest");
            ds.Show();
            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_user_ID.Text = "";
            txt_password.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
