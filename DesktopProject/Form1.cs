using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            SearchEmployee searchEmp = new SearchEmployee();
            searchEmp.Show();
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            AddEmployee addEmp = new AddEmployee();
            addEmp.Show();
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            DeleteEmployee delEmp = new DeleteEmployee();
            delEmp.Show();
        }


        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmp = new UpdateEmployee();
            updateEmp.Show();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount cr = new CreateAccount();
            cr.Show();
        }

        private void LoginIntoAccount_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }
    }
}
