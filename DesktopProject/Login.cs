using Microsoft.AspNetCore.Mvc;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginAccount_Click(object sender, EventArgs e)
        {
            string mail = LoginEmail.Text;
            string pwd = LoginPassword.Text;
            string constr = "Data Source=.;Initial Catalog=EmployeeManagement;Integrated Security=True";

            try
            { 
                using(SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"select * from LOGINCREDENTIAL where email = '{mail}' and password = '{pwd}'",conn);
                    cmd.Parameters.AddWithValue("mail",mail);
                    cmd.Parameters.AddWithValue("pwd",pwd);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Login Successfully....","Message",MessageBoxButtons.OK);
                        this.Close();
                        //UserHomeForm uhf = new UserHomeForm();
                        //uhf.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }catch(Exception err)
            {
                MessageBox.Show("Something Went Wrong...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
