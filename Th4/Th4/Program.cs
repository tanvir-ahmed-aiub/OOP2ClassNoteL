using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th4
{
    enum Day 
    {
        Sat=2,
        Sun=4,
        Mon=20,
        Tue=23,
        Wed=10,
        Thu,
        Fri
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr2D = { { 1, 2 }, { 2, 3 }, { 4, 5 }, { 5, 6 } };
            //Console.WriteLine(arr2D[2,0]);
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 2; j++) {
                    Console.Write(arr2D[i,j]+" ");
                }
                Console.WriteLine();
            }
            int[][] jagged = new int[3][];
            jagged[0] = new int[] { 1, 2, 3, 4 };
            jagged[1] = new int[] { 5, 6, 7 };
            jagged[2] = new int[] { 8, 9, 10 };

            for (int i = 0; i < jagged.Length; i++) {
                for (int j = 0; j < jagged[i].Length; j++) {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }

            var a = (int)Day.Sun;
            Console.WriteLine(a);
            
           



                
            
        }
    }
}
