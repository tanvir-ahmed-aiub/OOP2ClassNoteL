using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Library
{
    class Student
    {
        public string Name { get; set; }
        public string Id { get; set; }
        Borrow[] borrows;
        public int BorrowCount { get; set; }
        public Student() {
            borrows = new Borrow[100];
        }
        public Account Account { get; set; }
        //public int BorrowCount { get; set; }
        //public int Date { get; set; }
        public Student(string name, string id) {
            this.Name = name;
            this.Id = id;
            borrows = new Borrow[100];

        }
        public void ShowInfo() {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
        }
        public void AddBorrow(Borrow borrow) {
            borrows[BorrowCount++] = borrow;
        }
        public void ShowAllBorrows() {
            for (int i = 0; i < BorrowCount; i++) {
                borrows[i].ShowAllBooks();
            }
        }
    }
}
