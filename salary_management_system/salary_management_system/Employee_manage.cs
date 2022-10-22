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
    public partial class Employee_manage : Form
    {
        public Employee_manage()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=LAPTOP-ESOD9KSR;Initial Catalog=Employee_Management_System;Integrated Security=True";
        private void btn_emp_manage_view_Click(object sender, EventArgs e)
        {
            // Employee_details ed2 = new Employee_details();
            //ed2.Show();
            //this.Hide();
            Display();
           
            
        }
       
        private void btn_emp_home_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }

        private void btn_emp_add_Click(object sender, EventArgs e)
        {
            add();
            Display();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
            Display();
        }

        private void Employee_manage_Load(object sender, EventArgs e)
        {

        }

        private void DGVUpdatedetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Delete();
            Display();

        }
        public void Display()
        {
            string connectionString = @"Data Source=LAPTOP-ESOD9KSR;Initial Catalog=Employee_Management_System;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sql = "SELECT * FROM Employee_Details ";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            DGVUpdatedetails.DataSource = dtbl;
        }

        public void add()
        {
            try
            {
                if (txt_emp_ID.Text != "" && txt_emp_name.Text != "" && txt_emp_address.Text != "" && cmb_position.Text != "" && comb_education.Text != "" && comb_emp_gender.Text != "" && txt_phone.Text != "" && datetime_DOB.Text != "")
                {

                    SqlConnection con = new SqlConnection(connectionString);

                    con.Open();

                    string sql = @"INSERT INTO Employee_Details(Emp_ID,Emp_Name,Emp_Address,Emp_Position,Emp_Education,Emp_Gender,Emp_Tel,Emp_DOB)
                                  VALUES('" + txt_emp_ID.Text + "','" + txt_emp_name.Text + "','" + txt_emp_address.Text + "','" + cmb_position.SelectedItem + "','" + comb_education.SelectedItem + "','" + comb_emp_gender.SelectedItem + "','" + txt_phone.Text + "','" + datetime_DOB.Value.Date + "')";

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
            catch (Exception ex)
            {
                MessageBox.Show("connection fail");
            }
        }
        public void Edit()
        {

            if (txt_emp_ID.Text == "" || txt_emp_name.Text == "" || txt_emp_address.Text == "")
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
                    string query = "update Employee_Details set Emp_Name='" + txt_emp_name.Text + "',Emp_Address='" + txt_emp_address.Text + "',Emp_Position='" + cmb_position.SelectedItem.ToString() + "',Emp_Education='" + comb_education.SelectedItem.ToString() + "',Emp_Gender='" + comb_emp_gender.SelectedItem.ToString() + "',Emp_Tel='" + txt_phone.Text + "',Emp_DOB='" + datetime_DOB.Value.Date + "'where Emp_ID='" + txt_emp_ID.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Update Successfully");
                    con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        public void Delete()
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


        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            this.Hide();
        }
    }
}
