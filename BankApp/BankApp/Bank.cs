using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Bank
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private Employee[] employees;
        private int employeeCount;
        public int EmployeeCount
        {
            get { return employeeCount; }
            set { employeeCount = value; }
        }
        private Customer[] customers;
        private int customerCount;
        public int CustomerCount
        {
            get { return customerCount; }
            set { customerCount = value; }
        }
        public Bank()
        {
            employees = new Employee[100];
            customers = new Customer[1000];
            employeeCount = 0;
            customerCount = 0;
        }
        public Bank(string name)
        {
            this.name = name;
            employees = new Employee[100];
            customers = new Customer[1000];
            employeeCount = 0;
            customerCount = 0;
        }
        public void AddEmployee(params Employee[] employees)
        {
            foreach(var emp in employees)
            {
                if (employeeCount < 100)
                    this.employees[employeeCount++] = emp;
                else
                    Console.WriteLine("Employee is Full");
            }
           
        }
        public void AddCustomer(params Customer[] customers)
        {
            foreach(var customer in customers)
            {
                if (CustomerCount < 1000)
                    this.customers[customerCount++] = customer;
                else
                    Console.WriteLine("Customer is Full");
            }
           
        }
        public void ShowAllEmployees()
        {
            for (int i = 0; i < employeeCount; i++) {
                employees[i].ShowInfo();
            }
        }
        public void ShowAllCustomers()
        {
            for (int i = 0; i < customerCount; i++)
            {
                customers[i].ShowInfo();
            }
        }
        public Employee SearchEmployee(string id)
        {
            Employee e=null;
            for (int i = 0; i < employeeCount; i++)
            {
                if (id.Equals(employees[i].Id)) {
                    e = employees[i];
                    break;
                }
            }
            return e;
        }
        public Customer SearchCustomer(string id)
        {
            Customer c = null;
            for (int i = 0; i < customerCount; i++)
            {
                Customer cus = customers[i];
                if (cus.Id.Equals(id)){
                    c = cus;
                    break;
                }
            }
            return c;
        }



    }
}
