using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LeaveManagement
{
    class Connections
    {
        MySqlConnection dbconnect;
        string connect;

        public Connections()
        {
            this.connect = "datasource = localhost; username = root; password= ; database = leave management";
            this.dbconnect = new MySqlConnection(connect);

        }
        public MySqlCommand cmndInvoke(string s)
        {

            MySqlCommand cmnd = new MySqlCommand(s, dbconnect);
            cmnd.ExecuteNonQuery();
            return cmnd;
        }

        public MySqlDataReader cmndQueryAll(string s)
        {
            MySqlCommand cmnd = new MySqlCommand(s, dbconnect);
            var result = cmnd.ExecuteReader();
            return result;
        }

        public Object cmndQueryFirst(string s)
        {
            MySqlCommand cmnd = new MySqlCommand(s, dbconnect);
            var result = cmnd.ExecuteScalar();

            return result;
        }

        public string conString()
        {
            return this.connect;
        }

        public MySqlConnection getCon()
        {
            return this.dbconnect;
        }



        public void open()
        {
            dbconnect.Open();
        }

        public void close()
        {
            dbconnect.Close();
        }
    }
}
