using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DbConsole
{
    public class Database
    {
        public static SqlConnection ConnectDB() {
            string connString = "Server=DESKTOP-1HKAK02;Database=aiub_ums;User Id=sa;Password=1234;";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
