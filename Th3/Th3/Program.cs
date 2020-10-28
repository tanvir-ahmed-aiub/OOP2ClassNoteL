using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Th5;

namespace Th3
{
    class Program
    {
        static void Swap(ref int a,  ref int c)
        {
            int temp = c;
            c = a;
            a = temp;
            
        }
        static void Sum_Sub(int a, int c, out int sum, out int sub)
        {
            sum = a - c;
            sub = a - c;

        }
        static int add(params int[] a) {
            int sum=0;
            foreach (int i in a) {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int c = 12;
            Console.WriteLine("a: {0} c: {1}", a, c);
            Swap( ref a,  ref c);
            Console.WriteLine("a: {0} c: {1}", a, c);
            int sum =100;
            int sub =122;
            Sum_Sub(a, c,  out sum,  out sub);
            Console.WriteLine("Sum: {0} Sub: {1}", sum, sub);

            int[] arr = new int[5];
            string[] names = { "Rahim", "Karim", "Ahmed" };
            double[] num = new double[] { 10.5, 20.6, 3.5 };

            Console.WriteLine("Lengths: {0} {1} {2}",arr.Length,names.Length,num.Length);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            double sum_d = 0;
            foreach (double v in num) {
                sum_d += v;
            }
            Console.WriteLine("Sum is: {0}",sum_d);
            Console.WriteLine("Addition of Parameters: {0}", add(10, 15));
            Console.WriteLine("Addition of Parameters: {0}", add(10, 15,16,18,15));
            Console.WriteLine("Addition of Parameters: {0}", add());
            Console.WriteLine("Addition of Parameters: {0}", add(10, 15, 16));



        }
    }
}
