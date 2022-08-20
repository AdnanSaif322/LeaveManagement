using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaveManagement
{
    public partial class Manager_Login : Form
    {
        public Manager_Login()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Employee_Register ob = new Employee_Register();
            ob.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            ob.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"select * from employee_database where Employee_Id='{this.employeeIdtxt.Text}' and Security_Id='{this.securityIdtxt.Text}'";
                Connections con = new Connections();
                con.open();
                Object result = con.cmndQueryFirst(query);

                if (result != null)
                {
                    Employee_Application_Form ob = new Employee_Application_Form();
                    ob.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials.");
                }



            }
            catch (Exception error)
            {

                MessageBox.Show(" " + error);
            }
        }
    }
}
