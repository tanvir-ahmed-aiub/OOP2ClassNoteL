using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th6
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Horse();
            /*Cow cow = new Cow();
            Horse horse = new Horse();
            Snake snk = new Snake();
            Whale wh = new Whale();
            Human human = new Human();

            cow.Eat();
            horse.Sleep();
            snk.Move();
            wh.Sleep();
            Console.WriteLine();
            human.Sleep();
            cow.Sleep();
            human.Eat();
            cow.Move();*/
            Animal a1 = new Snake();
            //Animal a2 = new Human();
            Snake s1 = new Snake();
            s1.Move();
            a1.Move();

            s1.Eat();
            a1.Eat();
        }
    }
}
