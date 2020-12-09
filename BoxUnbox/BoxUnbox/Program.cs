using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxUnbox
{
    class Demo { }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10; //value type
            object boxed = i; //boxing
            int j = (int)boxed; //unboxing

            Demo d = new Demo();
            object d_boxed = d; //
            Demo d_unbox = (Demo)d_boxed;





        }
    }
}
