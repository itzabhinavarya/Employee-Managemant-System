using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopProject
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void mainHeading_Click(object sender, EventArgs e)
        {

        }

        private void backToHome_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void CreateEmpAccount_Click(object sender, EventArgs e)
        {
            string email = createAccountEmail.Text;
            string pwd = password.Text;

            string constr = "Data Source=.;Initial Catalog=EmployeeManagement;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"insert into LOGINCREDENTIAL(email, password)values('{email}','{pwd}')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully....");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Email Already Registered....","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
