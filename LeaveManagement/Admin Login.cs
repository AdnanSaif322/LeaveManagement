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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
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
                string query = $"select * from admin_login where User_Name='{this.nametxt.Text}' and Password='{this.passwordtxt.Text}'";
                Connections con = new Connections();
                con.open();
                Object result = con.cmndQueryFirst(query);
                if (result != null)
                {
                    Admin_check_form ob = new Admin_check_form();
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
