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
    public partial class CheckPwdMessage_box : Form
    {
        public CheckPwdMessage_box()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user_ID.Text == "ADMIN" && txt_password.Text == "1111")
            {
                Add_message ds = new Add_message();
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("your user name or Password Not Match Please try Agin");
            }
        }
    }
}
