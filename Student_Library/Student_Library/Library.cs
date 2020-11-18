using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Library
{
    class Library
    {
        public string Name { get; set; }
        Book[] listOfBooks;
        public int totalBook { get; set; }
        public Account Account { get; set; }
        public Library() {
            listOfBooks = new Book[100];
            borrows = new Borrow[1000];
        }
        public Library(string name) {
            Name = name;
            listOfBooks = new Book[100];
            borrows = new Borrow[1000];
        }
        Borrow[] borrows;
        public int BorrowCount { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Total : " + totalBook);
        }
        public void AddBook(params Book[] books) {
            foreach (var book in books) {
                if(totalBook < 100)
                    listOfBooks[totalBook++] = book;
            }
        }
        public void DeleteBook(Book book) {
            for (int i = 0; i < totalBook; i++) {
                if (book.Id.Equals(listOfBooks[i].Id)) {
                    for (int j = i; j < totalBook - 1; j++) {
                        listOfBooks[j] = listOfBooks[j + 1];
                    }
                    //listOfBooks[totalBook]= null;
                    totalBook--;
                    break;
                }
                
            }
        }
        public void AddNewBookCopy(Book book, int copy) {
            book.AddBookCopy(copy);
        }
        public Book SearchBook(string id) {
            Book b = null;
            for (int i = 0; i < totalBook; i++) {
                if (listOfBooks[i].Id.Equals(id)) {
                    b = listOfBooks[i];
                    break;
                }
            }
            return b;
        }
        public void ShowAllBooks() {
            for (int i = 0; i < totalBook; i++) {
                listOfBooks[i].ShowInfo();
            }
        }
        public void AddBorrow(params Borrow[] borrows)
        {   foreach(var borrow in borrows)
                this.borrows[BorrowCount++] = borrow;
        }
        public void ShowAllBorrows()
        {
            Console.WriteLine("---------------------------");
            for (int i = 0; i < BorrowCount; i++)
            {
                borrows[i].ShowAllBooks();
                Console.WriteLine("************************");
                borrows[i].Student.ShowInfo();
                Console.WriteLine("---------------------------");
            }
            Console.WriteLine("---------------------------");
        }
        public void ReturnBook(Student s,Borrow b)
        {
            int crDay = DateTime.Now.Day;
            if (crDay - b.Day > 5)
            {
                double amount = (crDay - b.Day - 5) * 10;
                s.Account.Transfer(amount, this.Account);
                Console.WriteLine("You have charged with {0} taka for {1} days late",amount, (crDay - b.Day - 5));
            }
            else {
                Console.WriteLine("Successfully returned with no charge");
            }
        }


    }
}
