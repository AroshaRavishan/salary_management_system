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
    public partial class Without_log : Form
    {
        public Without_log()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }
        private void fetchempdata()
        {
            string connectionString = @"Data Source=LAPTOP-ESOD9KSR;Initial Catalog=Employee_Management_System;Integrated Security=True";
           
            
            
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = " select * from Message_box ";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
           // MessageBox.Show("select * from Message_box");
            foreach (DataRow dr in dt.Rows)
            {
                lblmsg.Text = dr["message_show"].ToString();
                ///  txt_emp_name.Text = dr["Emp_Name"].ToString();
                //txtPos.Text = dr["Emp_Position"].ToString();


            }
                con.Close();
            


        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {

            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }
    }
}
