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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void btn_splash_continue_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void pictureBox_emp_Click(object sender, EventArgs e)
        {

            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
