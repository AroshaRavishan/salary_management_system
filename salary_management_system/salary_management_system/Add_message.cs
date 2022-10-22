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
    public partial class Add_message : Form
    {
        public Add_message()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=LAPTOP-ESOD9KSR;Initial Catalog=Employee_Management_System;Integrated Security=True";

        private void btnSave_Msg_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-ESOD9KSR;Initial Catalog=Employee_Management_System;Integrated Security=True";
            try
            {
                if (txtMsg.Text != "")
                {

                    SqlConnection con = new SqlConnection(connectionString);

                    con.Open();

                    string sql = @"INSERT INTO Message_box(message_show)
                                  VALUES('" + txtMsg.Text + "'')";

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
    }
}
    

