using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Connection
    {
        private SqlConnection conn = new SqlConnection ();
        public SqlConnection GetConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "data source = KARTHI\\SQLEXPRESS;database=library;Integrated security =True";
            if (conn.State == ConnectionState.Open )
            {
                conn.Close();
                conn.Open();
            }
            else
            {
                conn.Open();
            }
            return conn;
        }
        public void Getclose()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
}
