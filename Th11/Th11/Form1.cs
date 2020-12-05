using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Th11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AppearReg(object sender, EventArgs e)
        {
            new Registration().Show();
        }

        private void Authenticate(object sender, EventArgs e)
        {
            string name = "";
            string password = "";
            string errMsg = "";
            bool hasError = false;
            if (textBoxUsername.Text.Equals (""))
            {
                errMsg += "Username Required\n";
                hasError = true;
            }
            else
            {
                name = textBoxUsername.Text;
            }
            if (textBoxPassword.Text.Equals(""))
            {
                errMsg += "Password Required\n";
                hasError = true;
            }
            else
            {
                password = textBoxPassword.Text;
            }
            if (!hasError)
            {
                if (name.Equals("Tanvir") && password.Equals("12345678"))
                {
                    User u = new User();
                    u.Name = name;
                    u.Password = password;
                    //other fields from DB
                    new Dashboard(u).Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            else {
                MessageBox.Show(errMsg);
            }

        }
    }
}
