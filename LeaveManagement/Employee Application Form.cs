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
    public partial class Employee_Application_Form : Form
    {
        public Employee_Application_Form()
        {
            InitializeComponent();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            ob.Show();
            this.Hide();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connections con = new Connections();
                con.open();
                string query = $"INSERT INTO employee_application values ('' , '{this.employeeIdtxt.Text}' , '{this.employeeNametxt.Text}' , '{this.designationtxt.Text}' , '{this.fromTimePicker.Value.ToString("yyyyMMdd")}' , '{this.toTimePicker.Value.ToString("yyyyMMdd")}' , '{this.leaveStatusComboBox.Text}', '')";

                con.cmndInvoke(query);
                MessageBox.Show("Application Submitted.");
                employeeIdtxt.Text = string.Empty;
                securityIdtxt.Text = string.Empty;
                employeeNametxt.Text = string.Empty;
                designationtxt.Text = string.Empty;
                leaveStatusComboBox.Text = string.Empty;
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
            }
            
        }


        private void checkStatusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connections con = new Connections();
                con.open();
                string query = " ";

                query = $"select * from  employee_application where Employee_Id='{this.employeeIdtxt.Text}' order by id desc  ";

                var result = con.cmndQueryAll(query);

                if (result.Read())
                {
                    

                    string status = result["Status_Approve_or_not"].ToString();

                     if (status == string.Empty)
                     {
                         MessageBox.Show("Not yet checked.");
                     }
                    else
                    {
                        MessageBox.Show(status);
                    }

                }

                con.close();

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
            }
        }

        private void securityIdtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connections con = new Connections();
                con.open();
                string query = " ";

                query = $"select * from  employee_database where Employee_Id='{this.employeeIdtxt.Text}' and Security_Id='{this.securityIdtxt.Text}'";



                var result = con.cmndQueryAll(query);


                if (result.Read())
                {

                    string employeeName = result["Employee_Name"].ToString();
                    string designation = result["Designation"].ToString();


                    employeeNametxt.Text = employeeName;
                    designationtxt.Text = designation;

                }

                con.close();

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
            }

        }
    }
}
