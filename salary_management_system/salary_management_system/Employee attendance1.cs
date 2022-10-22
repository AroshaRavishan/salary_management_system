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
    public partial class Employee_attendance1 : Form
    {
        public Employee_attendance1()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=LAPTOP-ESOD9KSR;Initial Catalog=Employee_Management_System;Integrated Security=True";


        public void Display()
        {
            string connectionString = @"Data Source=LAPTOP-ESOD9KSR;Initial Catalog=Employee_Management_System;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sql = "SELECT * FROM Employee_Details where Emp_Position='" + cmb_position.Text + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            DGVATtendance.DataSource = dtbl;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void Employee_attendance1_Load(object sender, EventArgs e)
        {

        }
    }
}
