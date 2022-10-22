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
    public partial class Employee_details : Form
    {
        public Employee_details()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=LAPTOP-ESOD9KSR;Initial Catalog=Employee_Management_System;Integrated Security=True";
        private void fetchempdata()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = " select * from Employee_Details where Emp_ID='" + txt_emp_ID.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                LBLEMPID.Text = dr["Emp_ID"].ToString();
                LBLEMPNAME.Text = dr["Emp_Name"].ToString();
                LBLEMPADDRESS.Text = dr["Emp_Address"].ToString();
                LBLEMPPOS.Text = dr["Emp_Position"].ToString();
                LBLEMPEDU.Text = dr["Emp_Education"].ToString();
                LBLEMPGEN.Text = dr["Emp_Gender"].ToString();
                LBLEMPPHONE.Text = dr["Emp_Tel"].ToString();
                LBLEMPDOB.Text = dr["Emp_DOB"].ToString();
                LBLEMPID.Visible = true;

            }
            con.Close();
        }
        private void btn_emp_details_home_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }

        private void btn_emp_edit_Click(object sender, EventArgs e)
        {
            Employee_manage em1 = new Employee_manage();
            em1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Employee_details_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void btn_emp_delete_Click(object sender, EventArgs e)
        {

            if (txt_emp_ID.Text == "")
            {
                MessageBox.Show("Enter The Employeeb Id");
            }
            else
            {
                try
                {
                    string connectionString = @"Data Source=LAPTOP-ESOD9KSR;Initial Catalog=Employee_Management_System;Integrated Security=True";
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    string query = "delete from Employee_Details where Emp_ID='" + txt_emp_ID.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Delete Successfully");
                    con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("*** EMPLOYEE SUMMARY ***", new Font("gobold", 20, FontStyle.Bold), Brushes.Red, new Point(180));
            e.Graphics.DrawString("\n\nEmployee ID :"+LBLEMPID.Text+"\n\nEmployee Name :"+LBLEMPNAME.Text, new Font("gobold", 18, FontStyle.Bold), Brushes.Navy, new Point(80,100));
            e.Graphics.DrawString("\n\nEmployee Address :" + LBLEMPADDRESS.Text + "\n\nEmployee Position :" + LBLEMPPOS.Text, new Font("gobold", 18, FontStyle.Bold), Brushes.Navy, new Point(80, 200));
            e.Graphics.DrawString("\n\nEmployee Education :" + LBLEMPEDU.Text + "\n\nEmployee Gender :" + LBLEMPGEN.Text, new Font("gobold", 18, FontStyle.Bold), Brushes.Navy, new Point(80, 300));
            e.Graphics.DrawString("\n\nEmployee Phone :" + LBLEMPPHONE.Text + "\n\nEmployee Bithday :" + LBLEMPDOB.Text, new Font("gobold", 18, FontStyle.Bold), Brushes.Navy, new Point(80, 400));


            e.Graphics.DrawString("\n\n\n***EMPLOYEE SUMMARY ***", new Font("gobold", 20, FontStyle.Bold), Brushes.Red, new Point(180,700));

        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txt_emp_ID.Text = "";

            LBLEMPID.Text = "";
            LBLEMPNAME.Text = "";
            LBLEMPADDRESS.Text = "";
            LBLEMPPOS.Text = "";
            LBLEMPEDU.Text = "";
            LBLEMPGEN.Text = "";
            LBLEMPPHONE.Text = "";
            LBLEMPDOB.Text = "";
            
        }
    }
}
