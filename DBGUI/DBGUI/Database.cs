using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBGUI
{
    public class Database
    {
        public static SqlConnection ConnectDB() {
            string conString = "Server=DESKTOP-1HKAK02;Database=aiub_ums;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }
    }
}
