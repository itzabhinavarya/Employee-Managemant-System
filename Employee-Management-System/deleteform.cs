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
    public partial class deleteform : Form
    {
        public deleteform()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(deleteTextUserId.Text);
            string constr = "Data Source=.;Initial Catalog=FORMDB;Integrated Security=True";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(constr);
                conn.Open();
                SqlCommand cmd = new SqlCommand($"delete from FORMDATA where id = {id}",conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully......");
            }
            catch (Exception err)
            {
                MessageBox.Show($"Something Went Wrong...\n{err}");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
