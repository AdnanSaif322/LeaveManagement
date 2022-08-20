using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LeaveManagement
{
    public partial class Admin_check_form : Form
    {
        public Admin_check_form()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            ob.Show();
            this.Hide();
        }

        private void Admin_check_form_Load(object sender, EventArgs e)
        {
            try
            {
                Connections con = new Connections();
                con.open();
                string query = "select * from  employee_application where Status_Approve_or_not = '';";

                MySqlDataAdapter sqld = new MySqlDataAdapter();
                sqld.SelectCommand = new MySqlCommand(query, con.getCon());

                DataTable dTable = new DataTable();
                sqld.Fill(dTable);
                dataGridView1.DataSource = dTable;
                con.close();

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
            }
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to accept?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes) 
            {
                
                try
                {
                    Connections con = new Connections();
                    con.open();
                    string query = $"UPDATE employee_application set Status_Approve_or_not='Accepted' where  Id = '{this.employeeIdtxt.Text}';";

                    con.cmndInvoke(query);
                    employeeIdtxt.Text = string.Empty;
                    employeeNametxt.Text = string.Empty;
                    designationtxt.Text = string.Empty;
                    fromTimePicker.Text = string.Empty;
                    toTimePicker.Text = string.Empty;

                    string query2 = "select * from  employee_application where Status_Approve_or_not = '';";
                    MySqlDataAdapter sqld = new MySqlDataAdapter();
                    sqld.SelectCommand = new MySqlCommand(query2, con.getCon());

                    DataTable dTable = new DataTable();
                    sqld.Fill(dTable);
                    dataGridView1.DataSource = dTable;

                    con.close();
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.ToString());
                }
            }
            else
            {
                
            }
        }

        private void rejectBtn_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to reject?";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Connections con = new Connections();
                con.open();
                string query = $"UPDATE employee_application set Status_Approve_or_not='Rejected' where  Id = '{this.employeeIdtxt.Text}';";

                con.cmndInvoke(query);
                employeeIdtxt.Text = string.Empty;
                employeeNametxt.Text = string.Empty;
                designationtxt.Text = string.Empty;
                fromTimePicker.Text = string.Empty;
                toTimePicker.Text = string.Empty;

                string query2 = "select * from  employee_application where Status_Approve_or_not = '';";
                MySqlDataAdapter sqld = new MySqlDataAdapter();
                sqld.SelectCommand = new MySqlCommand(query2, con.getCon());

                DataTable dTable = new DataTable();
                sqld.Fill(dTable);
                dataGridView1.DataSource = dTable;

                con.close();
            }
            else
            {

            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            try
            {
                Connections con = new Connections();
                con.open();
                string query = " ";

                query = $"select * from  employee_application where Id='{this.employeeIdtxt.Text}'";

                var result = con.cmndQueryAll(query);

                if (result.Read())
                {
                    string employeeName = result["Employee_Name"].ToString();
                    string designation = result["Designation"].ToString();
                    string fromDate = result["From_Date"].ToString();
                    string toDate = result["To_Date"].ToString();

                    employeeNametxt.Text = employeeName;
                    designationtxt.Text = designation;
                    fromTimePicker.Text = fromDate;
                    toTimePicker.Text = toDate;

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
