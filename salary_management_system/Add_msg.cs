using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace salary_management_system
{
    public partial class Add_msg : Form
    {
        public Add_msg()
        {
            InitializeComponent();
        }

        private void btn_emp_add_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-ESOD9KSR;Initial Catalog=Employee_Management_System;Integrated Security=True";
            try
            {
                if (txtMsg.Text != "")
                {

                    SqlConnection con = new SqlConnection(connectionString);

                    con.Open();

                    string sql = @"INSERT INTO Message_box(message_show)
                                  VALUES('" + txtMsg.Text + "')";

                    SqlCommand command = new SqlCommand(sql, con);
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Reord has been succesfully enterd");
                }
                else
                {
                    MessageBox.Show("Fill all the details correctly");
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        private void txtMsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
          
        }

        private void btncheck_msg_Click(object sender, EventArgs e)
        {
            Without_log l1 = new Without_log();
            l1.Show();
            this.Hide();
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {

            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }
    }
}
