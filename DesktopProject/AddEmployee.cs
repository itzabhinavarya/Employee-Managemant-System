using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DesktopProject
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void mainHeading_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(addEmpIdTxtBox.Text);
            string name = addEmpNameTxtBox.Text;
            string email = addEmpEmailTxtBox.Text;
            string phone = addEmpPhoneTxtBox.Text;
            string city = addEmpCityTxtBox.Text;

            string constr = "Data Source=.;Initial Catalog=EmployeeManagement;Integrated Security=True";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"insert into EmployeeDetails(EmpId,EmpName,EmpEmail,EmpPhone,EmpCity) values({id},'{name}','{email}','{phone}','{city}')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully.....");
            }
            catch (Exception err)
            {
                MessageBox.Show("Something Went Wrong...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void backToHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
