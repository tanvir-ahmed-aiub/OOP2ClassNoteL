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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClicked(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = textBoxUsername.Text;
            user.Mobile = textBoxMobile.Text;
         
            RadioButton b = groupGender.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            user.Gender = b.Text;
            user.Profession = comboBoxProf.SelectedItem.ToString();

            /*string output = String.Format("Name: {0} " +
                "\nMobile: {1}" +
                "\nGender: {2}" +
                "\nProfession: {3}", name, mobile, gender, profession);
            rTOutput.Text = output;*/

            new Dashboard(user).Show();
        }
    }
}
