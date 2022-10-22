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
    public partial class Emp_Attendance : Form
    {
        public Emp_Attendance()
        {
            InitializeComponent();
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Display();
            
        }
        public void Display()
        {
            string connectionString = @"Data Source=LAPTOP-ESOD9KSR;Initial Catalog=Employee_Management_System;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sql = "SELECT * FROM Employee_Details where Emp_Position='" + cmb_position.Text + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            DGVAttendance.DataSource = dtbl;
        }

        private void txt_emp_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Edit();
            
        }

        private void Emp_Attendance_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void fetchempdata()
        {
            if (txt_emp_ID.Text == "")
            {
                MessageBox.Show("Enter Employee ID");
            }
            else
            {
                string connectionString = @"Data Source=LAPTOP-ESOD9KSR;Initial Catalog=Employee_Management_System;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = " select * from mark_Attendance where Emp_Date='" + datetime_empatd.Value.Date + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txt_emp_ID.Text = dr["Emp_ID"].ToString();
                   // txt_emp_name.Text = dr["Emp_Name"].ToString();
                   // txtPos.Text = dr["Emp_Position"].ToString();
                    txtattendance.Text = dr["Emp_attendane"].ToString();


                }
                con.Close();
            }


        }
        public void Edit()
        {

            if (txt_emp_ID.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string connectionString = @"Data Source=LAPTOP-ESOD9KSR;Initial Catalog=Employee_Management_System;Integrated Security=True";
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    string query = @"INSERT INTO mark_Attendance (Emp_ID,Emp_Date,Emp_attendane)
                        VALUES('"+txt_emp_ID.Text+"','"+datetime_empatd.Value.Date+"','"+cmbAtd.SelectedItem+"')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Attendance Successfully");
                    con.Close();

                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txt_emp_ID.Text = "";
            cmbAtd.Text = "";
            datetime_empatd.Text = "";
            txtattendance.Text = "";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lbldatee.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblSecond.Location = new Point(lblTime.Location.X + lblTime.Width - 5, lblSecond.Location.Y);
        }
    }
}
