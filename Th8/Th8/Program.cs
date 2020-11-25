using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th8
{
    class Program
    {
        static void Main(string[] args)
        {
            Toyota c = new Toyota("X-Corolla","24235346536","2009");
            c.ShowInfo();
            c.SpeedUp();

            Lamborgini l = new Lamborgini("Huraka", "343465447", "2018");
            l.NOS();
            l.EmergencyBrake();
            l.Start();
            l.ShowInfo();

            
           
        }
    }
}
