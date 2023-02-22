using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopProject
{
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void mainHeading_Click(object sender, EventArgs e)
        {

        }
        public void SearchEmpButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(addEmpIdTxtBox.Text);

            string constr = "Data Source=.;Initial Catalog=EmployeeManagement;Integrated Security=True";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"select * from EmployeeDetails where EmpId = {id}", conn);
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.Read())
                {
                    addEmpIdTxtBox.Text = dreader[0].ToString();
                    addEmpNameTxtBox.Text = dreader[1].ToString();
                    addEmpEmailTxtBox.Text = dreader[2].ToString();
                    addEmpPhoneTxtBox.Text = dreader[3].ToString();
                    addEmpCityTxtBox.Text = dreader[4].ToString();
                }
                else
                {
                    MessageBox.Show("Employee Record Not Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    addEmpIdTxtBox.Text = "";
                    addEmpNameTxtBox.Text = "";
                    addEmpEmailTxtBox.Text = "";
                    addEmpPhoneTxtBox.Text = "";
                    addEmpCityTxtBox.Text = "";
                }
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

        private void addEmpCityTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void empCity_Click(object sender, EventArgs e)
        {

        }

        private void addEmpPhoneTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void empPhone_Click(object sender, EventArgs e)
        {

        }

        private void addEmpEmailTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void empEmail_Click(object sender, EventArgs e)
        {

        }

        private void addEmpNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void empName_Click(object sender, EventArgs e)
        {

        }

        private void addEmpIdTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpId_Click(object sender, EventArgs e)
        {

        }

        private void backToHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
