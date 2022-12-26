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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Button Clicked");
            int id = int.Parse(txtUserID.Text);
            string name = txtUserName.Text;
            string email = txtUserEmail.Text;
            string city = txtUserCity.Text;

            string constr = "Data Source=.;Initial Catalog=FORMDB;Integrated Security=True";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"insert into FORMDATA(id,name,email,city)values({id},'{name}','{email}','{city}')",conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Inserted Successfully.....");
            }
            catch (Exception err)
            {
                MessageBox.Show($"Something Went Wrong... \n{err.Message}");
                Console.WriteLine("Error Occured.....!!!\n"+err.Message);
                Console.WriteLine("\n\n\n"+err.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        private void empID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void deleteDataBtn_Click(object sender, EventArgs e)
        {
            deleteform delform = new deleteform();
            delform.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateForm uform = new UpdateForm();
            uform.Show();
        }

        private void tatti_Click(object sender, EventArgs e)
        {
            UpdateForm u = new UpdateForm();
            u.Show();
        }
    }
}
