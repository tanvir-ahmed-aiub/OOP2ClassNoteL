using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DbConsole
{
    class Program
    {
        static void ShowAllUsers() {
            SqlConnection conn = Database.ConnectDB();
            conn.Open();
            string query = "SELECT * FROM Users";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Id\t\tName\t\tEmail\t\tCgpa");
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string name = reader.GetString(1);
                string email = reader.GetString(2);
                double cgpa = reader.GetDouble(3);

                Console.WriteLine("{0}\t{1}\t{2}\t{3}", id, name, email, cgpa);

            }
            conn.Close();
        }
        static void InsertCourse(string cCode,string cName) {
            SqlConnection conn = Database.ConnectDB();
            conn.Open();
            //string query = "INSERT INTO Courses VALUES ('"+ cCode + "','"+ cName + "')";
            string query = String.Format("INSERT INTO Courses VALUES ('{0}','{1}')",cCode,cName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                Console.WriteLine("Added");
            }
            else
            {
                Console.WriteLine("Not Added");
            }
            conn.Close();
        }
        static void Main(string[] args)
        {
            ShowAllUsers();
            InsertCourse("CSC09", "ACN");
        }
    }
}
