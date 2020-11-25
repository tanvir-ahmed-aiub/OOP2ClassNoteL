using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th8
{
    class Lamborgini : Car, IBasicCar, IRacingCar
    {
        public Lamborgini() { }
        public Lamborgini(string name, string chassis, string year):base(name,chassis,year) {

        }
        public void Brake()
        {
            Console.WriteLine("Braking of lamborgini");
        }

        public void EmergencyBrake()
        {
            Console.WriteLine("EmergencyBraking of lamborgini");
        }

        public void ExtraSpeed()
        {
            Console.WriteLine("Extraspeed of lamborgini");
        }

        public void GearUp()
        {
            Console.WriteLine("Gearup of lamborgini");
        }

        public void NOS()
        {
            Console.WriteLine("NOS of lamborgini");
        }

        public void SpeedUp()
        {
            Console.WriteLine("SpeedUP of lamborgini");
        }

        public void Start()
        {
            Console.WriteLine("Start of lamborgini");
        }
    }
}
