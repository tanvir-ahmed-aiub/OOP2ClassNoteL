using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th3
{
    public class Student
    {
        string id;
        string name;
        float cgpa;

        public string Id {
            protected set { id = value; }
            get { return id; }

        }
        public Student() { }
        public Student(string id) {
            this.id = id;
        }
        public void showInfo() {
            Id = "1223234";
        }

    }
}
