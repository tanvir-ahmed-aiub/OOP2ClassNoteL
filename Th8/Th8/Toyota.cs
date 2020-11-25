using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th8
{
    class Toyota : Car, IBasicCar
    {
        public Toyota() { }
        public Toyota(string name,string chassis,string year) : base(name, chassis, year)
        {

        }
        public void Brake()
        {
            Console.WriteLine("Braking of toyota");
        }

        public void GearUp()
        {
            Console.WriteLine("Gearup of toyota");
        }

        public void SpeedUp()
        {
            Console.WriteLine("Speedup of toyota");
        }

        public void Start()
        {
            Console.WriteLine("Starting of toyota");
        }
    }
}
