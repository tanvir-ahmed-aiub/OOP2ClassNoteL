using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th5
{
    class Student : Person
    {
        private float cgpa;
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        private int credit;
        public int Credit
        {
            get { return credit; }
            set { credit = value; }
        }
        private int course;
        public int Course
        {
            get { return course; }
            set { course = value; }
        }
        public Student() 
        {
            Console.WriteLine("Student Default");
        }
        public Student(string name) : base(name,"3454","ddg")
        {
            Console.WriteLine("Student 1 parameter");
        }
        public Student(string name,string id) : base(name,id)
        {
            Console.WriteLine("Student 2 parameter");
        }
        public Student(string name,string id,string bg)
        {
            Console.WriteLine("Student 3 parameter");
        }
        


    }
}
