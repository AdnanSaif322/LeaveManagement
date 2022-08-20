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
    public partial class Employee_Register : Form
    {
        public Employee_Register()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Manager_Login ob = new Manager_Login();
            ob.Show();
            this.Hide();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connections con = new Connections();
                con.open();
                string query = $"INSERT INTO employee_database values ('' , '{this.securityIdtxt.Text}' , '{this.nametxt.Text}' , '{this.designationtxt.Text}')";

                con.cmndInvoke(query);
                MessageBox.Show("Registered Successfully.");
                employeeIdtxt.Text = string.Empty;
                securityIdtxt.Text = string.Empty;
                nametxt.Text = string.Empty;
                designationtxt.Text = string.Empty;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
            }
        }
    }
}
