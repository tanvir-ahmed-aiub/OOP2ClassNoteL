using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Th2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Tanvir","1111111",2.4f);
            s1.ShowInfo();
            s1.Name = "Tanvir";
            Console.WriteLine(s1.Name);
        }
    }
}
