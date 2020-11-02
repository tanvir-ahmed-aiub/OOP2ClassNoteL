using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th5
{
    class Person
    {
        string name;
        public string Name{
            get { return name; }
            set { name = value; }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string dob;
        public string DOB
        {
            get { return dob; }
            set { dob = value; }
        }
        private string bg;
        public string BG
        {
            get { return bg; }
            set { bg = value; }
        }
        public Person()
        {
            Console.WriteLine("Person Default");
        }
        public Person(string name)
        {
            Console.WriteLine("Person 1 Parameter");
            this.name = name;
        }
        public Person(string name,string id)
        {
            Console.WriteLine("Person 2 Parameter");
            this.name = name;
            this.id = id;
        }
        public Person(string name, string id,string bg)
        {
            Console.WriteLine("Person 3 Parameter");
            this.name = name;
            this.id = id;
            this.bg = bg;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("DOB: " + DOB);
            Console.WriteLine("Blood Grp: " + BG);
        }
    }
}
