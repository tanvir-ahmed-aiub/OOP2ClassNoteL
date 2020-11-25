using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // Nullable<int> i = null;
            int? i = null;
            double? d = null; //Nullable <double> d
            Console.WriteLine(i);
            

            Bank b = new Bank("Sonali Bank");
            Employee e1 = new Employee("123","Tanvir");
            Employee e2 = new Employee("124","Sabbir");
            b.AddEmployee(e1,e2);
            //b.ShowAllEmployees();

            Customer c = new Customer("1","Tanvir","Dhaka");
            //Account a = new Account();
            Account a1 = new SavingsAccount("3245","Tanvir",120.00);
            Account a2 = new FixedAccount("3246","Tanvir",50000.00,2015,5);
            c.AddAccount(a1,a2);
            c.ShowAllAccounts();




        }
    }
}
