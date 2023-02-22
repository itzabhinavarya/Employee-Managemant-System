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
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void backToHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void DeleteEmpButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(addEmpIdTxtBox.Text);
            string constr = "Data Source=.;Initial Catalog=EmployeeManagement;Integrated Security=True";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"delete from EmployeeDetails where EmpId = {id}", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully...");
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

        private void DeleteEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
