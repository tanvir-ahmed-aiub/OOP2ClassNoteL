using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th10
{
    class Student
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public Student() { }
        public Student(string name, string id) {

            Name = name;
            Id = id;
        }
        public void ShowInfo() {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
        }
    }
}
