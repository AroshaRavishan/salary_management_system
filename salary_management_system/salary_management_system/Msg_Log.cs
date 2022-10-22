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
    public partial class Msg_Log : Form
    {
        public Msg_Log()
        {
            InitializeComponent();
        }

        private void btn_splash_continue_Click(object sender, EventArgs e)
        {
            if (cmb_position.Text == "")
            {
                MessageBox.Show("Only MANAGER & DIRECTOR");
            }

            else
            {

                if (cmb_position.Text == "MANAGER")
                {
                    Check_Pwd l1 = new Check_Pwd();
                    l1.Show();
                    this.Hide();
                }
                else if (cmb_position.Text == "DIRECTOR")
                {
                    Check_Pwd l1 = new Check_Pwd();
                    l1.Show();
                    this.Hide();
                }
            }
           
        }

        private void cmb_position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_emp_posititon_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(cmb_position.SelectedIndex==0)
            {
                Without_log l1 = new Without_log();
                l1.Show();
                this.Hide();
            }
            else if(cmb_position.SelectedIndex==1)
            {
                Without_log l1 = new Without_log();
                l1.Show();
                this.Hide();
            }

             else if (cmb_position.Text == "SENIOR DEVELOPPER")
             {

                Without_log l1 = new Without_log();
                l1.Show();
                this.Hide();
             }
            else if (cmb_position.Text == "JUNIOR DEVELOPPER")
            {

                Without_log l1 = new Without_log();
                l1.Show();
                this.Hide();
            }

            else if (cmb_position.Text == "ACCOUNTATNT")
            {
                Without_log l1 = new Without_log();
                l1.Show();
                this.Hide();
            }
            else if (cmb_position.Text == "RECEPTIONIST")
            {

                Without_log l1 = new Without_log();
                l1.Show();
                this.Hide();
            }
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {

            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }
    }
}
