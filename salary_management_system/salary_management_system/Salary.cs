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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=LAPTOP-ESOD9KSR;Initial Catalog=Employee_Management_System;Integrated Security=True";
        private void btn_salary_home_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }
        private void fetchempdata()
        {
            if(txt_emp_ID.Text =="")
            {
                MessageBox.Show("Enter Employee ID");
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = " select * from Employee_Details where Emp_ID='" + txt_emp_ID.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txt_emp_ID.Text = dr["Emp_ID"].ToString();
                    txt_emp_name.Text = dr["Emp_Name"].ToString();
                    txtPos.Text = dr["Emp_Position"].ToString();
                    

                }
                con.Close();
            }

            
        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void btn_emp_manage_home_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }
        int Daily_Basic,total=0,ot_hours;

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_emp_ID.Text = "";
            txt_emp_name.Text = "";
            txtPos.Text = "";
            txtEmp_workeddays.Text = "";
            txtsalary.Text = "";
            txt_ot_Hours.Text = "";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("*** EMPLOYEE SALARY DOCUMNENT ***", new Font("gobold", 20, FontStyle.Bold), Brushes.Red, new Point(180));
            e.Graphics.DrawString("\n\nEmployee ID :" + txt_emp_ID.Text + "\n\nEmployee Name :" + txt_emp_name.Text, new Font("gobold", 18, FontStyle.Bold), Brushes.Navy, new Point(80, 100));
            e.Graphics.DrawString("Employee Position :" + txtPos.Text, new Font("gobold", 18, FontStyle.Bold), Brushes.Navy, new Point(80, 200));
            e.Graphics.DrawString("\n\nEmployee Work Days :" + txtEmp_workeddays.Text + "\n\nEmployee Ot Hours :" + txt_ot_Hours.Text, new Font("gobold", 18, FontStyle.Bold), Brushes.Navy, new Point(80, 300));
            e.Graphics.DrawString("\n\nDaily Pay:" + Daily_Basic, new Font("gobold", 18, FontStyle.Bold), Brushes.Navy, new Point(80, 400));
            e.Graphics.DrawString("\n\nOT Hour Payment:" +ot_hours, new Font("gobold", 18, FontStyle.Bold), Brushes.Navy, new Point(80, 500));
            e.Graphics.DrawString("\n\nEmployee Salary:" + txtsalary.Text , new Font("gobold", 18, FontStyle.Bold), Brushes.Navy, new Point(80, 600));



            e.Graphics.DrawString("\n\n\n***EMPLOYEE SALARY ***", new Font("gobold", 20, FontStyle.Bold), Brushes.Red, new Point(180, 700));

        }

        private void txt_emp_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void btn_emp_manage_view_Click(object sender, EventArgs e)
        {
           
            if (txtPos.Text == "")
            {
                MessageBox.Show("Select An Employee ");
            }
            else if(txtEmp_workeddays.Text=="" || Convert.ToInt32( txtEmp_workeddays.Text) > 30)
            {
                MessageBox.Show("Select A Valid Number Of Days ");
            }
            else
            {
                if(txtPos.Text == "MANAGER")
                {
                    Daily_Basic = 2500;
                    ot_hours = 500;
                }
                else if(txtPos.Text== "SENIOR DEVELOPPER")
                {
                    Daily_Basic = 2000;
                    ot_hours = 500;
                }
                else if(txtPos.Text== "JUNIOR DEVELOPPER")
                {
                    Daily_Basic = 1750;
                    ot_hours = 500;
                }
                else if (txtPos.Text== "ACCOUNTATNT")
                {
                    Daily_Basic = 1500;
                    ot_hours = 500;
                }
                else if (txtPos.Text== "RECEPTIONIST")
                {
                    Daily_Basic = 1000;
                    ot_hours = 500;
                }
                else
                {
                    MessageBox.Show("Wrong Input");
                }
                total =( Daily_Basic * Convert.ToInt32(txtEmp_workeddays.Text)+ ot_hours * Convert.ToInt32(txt_ot_Hours.Text));

                txtsalary.Text = Convert.ToString(total);
            }
        }
    }
}
