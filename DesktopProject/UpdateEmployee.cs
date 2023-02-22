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
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void backToHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void UpdateEmpButton_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand($"update EmployeeDetails set EmpName = '{name}',EmpEmail = '{email}',EmpPhone = '{phone}',EmpCity = '{city}' where EmpId = {id}", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully.....");
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
    }
}
