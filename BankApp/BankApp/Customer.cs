using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Customer
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private Account[] accounts;
        private int acccCount;

        public int AccCount
        {
            get { return acccCount; }
            set { acccCount = value; }
        }

        public Customer() {
            accounts = new Account[10];
            acccCount = 0;
        }
        public Customer(string id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            accounts = new Account[10];
            acccCount = 0;
        }
        public void AddAccount(params Account[] accounts) {
            foreach (var acc in accounts) {
                if (acccCount < 10)
                    this.accounts[acccCount++] = acc;
                else
                    Console.WriteLine("Cannot create acc: {0}",acc.AccNo);
            }
        }
        public void ShowAllAccounts()
        {
            for (int i = 0; i < acccCount; i++) {
                accounts[i].ShowInfo();
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
        }

    }
}
