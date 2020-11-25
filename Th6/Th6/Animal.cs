using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th6
{
    abstract class Animal
    {
        virtual public void Eat()
        {
            Console.WriteLine(" eat with hand");
        }
        public void Sleep()
        {
            Console.WriteLine(" sleep lying");
        }
        public void Move()
        {
            Console.WriteLine(" move with legs");
        }
        public void Express()
        {
            Console.WriteLine(" sounds with mouth");
        }
        abstract public void Bath();
       
    }
}
