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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public Home(string user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                btn_view.Hide();
                btn_salary.Hide();
                pictureBox_view.Hide();
                pictureBox_salary.Hide();
                btnpaysheet.Hide();
                pictureBox4.Hide();



            }
            else if (user == "ADMIN")
            {
                btn_employee.Show();
                btn_view.Show();
                btn_salary.Show();
               
            }
        }
        private void btn_employee_Click(object sender, EventArgs e)
        {
            Employee_manage emp1 = new Employee_manage();
            emp1.Show();
            this.Hide();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Employee_details ed1 = new Employee_details();
            ed1.Show();
            this.Hide();
        }

        private void pictureBox_emp_Click(object sender, EventArgs e)
        {
            Employee_manage emp1 = new Employee_manage();
            emp1.Show();
            this.Hide();
        }

        private void pictureBox_view_Click(object sender, EventArgs e)
        {
            Employee_details ed2 = new Employee_details();
            ed2.Show();
            this.Hide();
        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            Salary s1 = new Salary();
            s1.Show();
            this.Hide();
        }

        private void pictureBox_salary_Click(object sender, EventArgs e)
        {
            Salary s1 = new Salary();
            s1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnAttendanve_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAtTendance_Click(object sender, EventArgs e)
        {
            Emp_Attendance e1 = new Emp_Attendance();
            e1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Emp_Attendance e1 = new Emp_Attendance();
            e1.Show();
            this.Hide();
        }

        private void btnMSG_Click(object sender, EventArgs e)
        {
            Msg_Log s1 = new Msg_Log();
            s1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Msg_Log s1 = new Msg_Log();
            s1.Show();
            this.Hide();
        }

        

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblSecond.Location = new Point(lblTime.Location.X + lblTime.Width-5, lblSecond.Location.Y)
;        }

        private void btnpaysheet_Click(object sender, EventArgs e)
        {
            Pay_sheet s1 = new Pay_sheet();
            s1.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Pay_sheet s1 = new Pay_sheet();
            s1.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
