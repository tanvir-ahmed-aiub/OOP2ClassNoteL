using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th2
{
    class Student //internal acess
    {
        //fields
        string name;
        string id;
        float cgpa;
        public const int NO_OF_CREDIT= 10;
        public readonly int NO_OF_COURSE;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Student() {
            name = "default";
            id = "XXXXXX";
            cgpa = 2.4f;
            NO_OF_COURSE = 4;
            
        }
        public Student(string name, string id, float cgpa) {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
            NO_OF_COURSE = 4;
        }
        internal void ShowInfo() {
           
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Id: "+id);
            Console.WriteLine("Cgpa: "+cgpa);
            Console.WriteLine(NO_OF_CREDIT+" " + NO_OF_COURSE);
        }
    }
}
