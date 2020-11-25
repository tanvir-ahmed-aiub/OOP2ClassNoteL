using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th8
{
    abstract class Car
    {
        public string Name { get; set; }
        public string Chassis { get; set; }
        public string Year { get; set; }
        
        public Car() { }
        public Car(string name, string chassis, string year) {
            Name = name;
            Chassis = chassis;
            Year = year;
        }
        public void ShowInfo() {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Chassis: " + Chassis);
            Console.WriteLine("Year: " + Year);
        }
    }
}