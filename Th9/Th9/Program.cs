using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th9
{
    class Demo
    {
        public static void Multiply(int x, int y) {
            Console.WriteLine("Multiply: " + (x * y));
        }
        public static void Div(int x, int y)
        {
            Console.WriteLine("Div: " + (x / y));
        }
    }
    class Program
    {
        public delegate void Calc(int x, int y);

        public static void Add(int x, int y) {
            Console.WriteLine("Sum: " + (x+y));
        }
        public static void Sub(int a, int b) {
            Console.WriteLine("Sub: " + (a - b));
        }
        static void Main(string[] args)
        {
            Calc handler = Add;
            handler = handler + Sub;

            //handler(12, 10);

            Calc handler2 = Demo.Multiply;
            handler2 += Demo.Div;
            //handler2(14, 10);

            Calc sumDel = handler + handler2;

            sumDel(14,7);
            Console.WriteLine("-------------------------");
            //sumDel -= Add;
            sumDel -= handler;
            sumDel(15, 5);



        }
    }
}
