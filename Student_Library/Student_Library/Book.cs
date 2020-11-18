using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Library
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Id { get; set; }
        public int Copy { get; set; }

        public Book() { }
        public Book(string name, string author, string id, int copy) {
            Name = name;
            Author = author;
            Id = id;
            Copy = copy;
        }
        public void ShowInfo() {
            Console.WriteLine("Name: "+ Name);
            Console.WriteLine("Author: "+ Author);
            Console.WriteLine("Id: "+ Id);
            Console.WriteLine("Copy: "+ Copy);
        }
        public void AddBookCopy(int x) {
            Copy += x;
        }
    }
}
