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
    public partial class Pay_sheet : Form
    {
        public Pay_sheet()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=LAPTOP-ESOD9KSR;Initial Catalog=Employee_Management_System;Integrated Security=True";
        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            Home s1 = new Home();
            s1.Show();
            this.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }
        public void fetchempdata()
        {
            if (txt_emp_ID.Text == "")
            {
                MessageBox.Show("Enter Employee ID");
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = " select * from paysheet where    Emp_ID ='" + txt_emp_ID.Text + "' and  Emp_Month ='" + comb_pay_month.SelectedItem + "'  ";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txt_emp_ID.Text = dr["Emp_ID"].ToString();
                    lblpayid.Text= dr["paysheet_id"].ToString();
                    lblEmpname.Text = dr["Emp_ID"].ToString();
                    //  lblpos.Text = dr["Emp_Position"].ToString();
                    lblpaymonth.Text = dr["Emp_Month"].ToString();
                    lblwrkdays.Text = dr["Emp_work_days"].ToString();
                    lblsal.Text = dr["Emp_salary"].ToString();


                }
                con.Close();
            }
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
