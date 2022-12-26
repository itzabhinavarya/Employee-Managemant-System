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

namespace newForm
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(UpdatetxtUserID.Text);
            string constr = "Data Source=.;Initial Catalog=FORMDB;Integrated Security=True";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"select * from FORMDATA where id = {id}",conn);
                SqlDataReader dreader = cmd.ExecuteReader();
                if (dreader.Read())
                {
                    UpdatetxtUserID.Text = dreader[0].ToString();
                    UpdatetxtUserName.Text = dreader[1].ToString();
                    UpdatetxtUserEmail.Text = dreader[2].ToString();
                    UpdatetxtUserCity.Text = dreader[3].ToString();
                }
                else
                {
                    UpdatetxtUserID.Text = "";
                    UpdatetxtUserName.Text = "";
                    UpdatetxtUserEmail.Text = "";
                    UpdatetxtUserCity.Text = "";
                    MessageBox.Show("Record unavailable in database....");
                }
                dreader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Something Went Wrong \n{err.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(UpdatetxtUserID.Text);
            string name = UpdatetxtUserName.Text;
            string email = UpdatetxtUserEmail.Text;
            string city = UpdatetxtUserCity.Text;
            string constr = "Data Source=.;Initial Catalog=FORMDB;Integrated Security=True";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"update FORMDATA set name='{name}',email='{email}',city='{city}' where id={id}", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully....");
            }
            catch (Exception err)
            {
                MessageBox.Show("Something went wrong...!!!"+err.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
