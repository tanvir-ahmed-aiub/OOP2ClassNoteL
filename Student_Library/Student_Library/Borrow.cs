using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Library
{
    class Borrow
    {
        public string Id { get; set; }
        Book[] books;
        public Student Student { get; set; }
        public int BookCount { get; set; }
        public int Day { get; set; }

        public Borrow() {
            books = new Book[5];
        }
        public Borrow(string id, Student student,int day) {
            Id = id;
            Student = student;
            Day = day;
            books = new Book[5];
        }
        public void AddBook(params Book[] books) {
            foreach (var book in books) {
                if (BookCount < 5)
                {
                    this.books[BookCount++] = book;
                }
                else {
                    Console.WriteLine("Can not add "+ book.Name);
                }
            }
        }
        public void DeleteBook(Book book)
        {
            for (int i = 0; i < BookCount; i++)
            {
                if (book.Id.Equals(books[i].Id))
                {
                    for (int j = i; j < BookCount - 1; j++)
                    {
                        books[j] = books[j + 1];
                    }
                    //listOfBooks[totalBook]= null;
                    BookCount--;
                    break;
                }

            }
        }
        public Book SearchBook(string id)
        {
            Book b = null;
            for (int i = 0; i < BookCount; i++)
            {
                if (books[i].Id.Equals(id))
                {
                    b = books[i];
                    break;
                }
            }
            return b;
        }
        public void ShowAllBooks()
        {
            Console.WriteLine("Borrowed On : " + Day);
            for (int i = 0; i < BookCount; i++)
            {
                books[i].ShowInfo();
            }
        }

    }
}
