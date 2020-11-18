using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library l1 = new Library("AIUB Library");
            Book b1 = new Book("Padma Nadir Majhi", "Manik", "1001", 5);
            Book b2 = new Book("Hazar Bochor Shore", "Zahir", "1002", 4);
            Book b3 = new Book("Harry Potter 1", "J.K", "1003", 4);
            Book b4 = new Book("Harry Potter 2", "J.K", "1004", 4);

            l1.AddBook(b1,b2,b3,b4);
            //l1.ShowAllBooks();

            Book temp = l1.SearchBook("1004");
            if (temp != null) {
                l1.AddNewBookCopy(temp,5);
            }
            Book b5 = new Book("C++ The Complete Reference", "Herbert Schildit", "1005", 10);
            l1.AddBook(b5);
            Console.WriteLine("-------------------");
            //l1.ShowAllBooks();

            Student s1 = new Student("Tanvir","1002");
            Borrow br1 = new Borrow("br-0001",s1,7);
            br1.AddBook(b1,b2,b3);
            s1.AddBorrow(br1);

            Borrow br2 = new Borrow("br-0002", s1, 2);
            br2.AddBook(b4,b5);
            s1.AddBorrow(br2);

            Student s2 = new Student("Maruf", "1003");
            Borrow br3 = new Borrow("br-0003", s2, 6);
            br3.AddBook(b1,b2,b3,b4,b5);
            s2.AddBorrow(br3);
            Console.WriteLine("-------------------");
            //s1.ShowAllBorrows();
            Console.WriteLine("-------------------");
            //s2.ShowAllBorrows();
            l1.AddBorrow(br1,br2,br3);
            //l1.ShowAllBorrows();

            Account acc1 = new Account("Tanvir","12345",500.00);
            s1.Account = acc1;
            Account acc2 = new Account("Library", "12346", 10000.00);
            l1.Account = acc2;

            l1.ReturnBook(s1,br1);
            l1.ReturnBook(s1,br2);

            Console.WriteLine("s1 Students Balance: " + s1.Account.Balance);
            Console.WriteLine("Library Balance: " + l1.Account.Balance);




        }
    }
}
