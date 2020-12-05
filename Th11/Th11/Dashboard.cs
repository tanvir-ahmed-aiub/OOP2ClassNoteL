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
    public partial class Dashboard : Form
    {
        public Dashboard(User user)
        {
            InitializeComponent();

            string output = String.Format("Name: {0} " +
                "\nMobile: {1}" +
                "\nGender: {2}" +
                "\nProfession: {3}", user.Name, user.Mobile, user.Gender, user.Profession);
            rTOutput.Text = output;

        }
    }
}
