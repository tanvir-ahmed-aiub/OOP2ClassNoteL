using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th5
{
    class Teacher:Person
    {
        private double sal;

        public double Sal
        {
            get { return sal; }
            set { sal = value; }
        }
        private int wh;

        public int Wh
        {
            get { return wh; }
            set { wh = value; }
        }
        public Teacher() :base("")
        { }

    }
}
