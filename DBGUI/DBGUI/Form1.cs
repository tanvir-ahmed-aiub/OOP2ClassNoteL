using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var courses = GetCourses();
            gridCourses.DataSource = courses;
            
            /*SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            gridCourses.DataSource = ds.Tables[0];*/

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string cCode = textBoxCCode.Text;
            string cName = textBoxCName.Text;
            var conn = Database.ConnectDB();
            conn.Open();
            string query = String.Format("INSERT INTO Courses VALUES('{0}','{1}')", cCode, cName);
            SqlCommand cmd = new SqlCommand(query,conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Value Inserted");
            }
            else {
                MessageBox.Show("Value Not Inserted");
            }
            conn.Close();
            var courses = GetCourses();
            gridCourses.DataSource = courses;
        }
        private ArrayList GetCourses() {
            var conn = Database.ConnectDB();
            conn.Open();
            string query = "SELECT * FROM Courses";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList courses = new ArrayList();
            while (reader.Read())
            {
                Course c = new Course();

                c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                courses.Add(c);
            }
            conn.Close();
            return courses;
        }
    }
}
