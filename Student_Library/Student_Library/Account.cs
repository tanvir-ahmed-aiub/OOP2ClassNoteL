using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Library
{
    class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; set; }
        public double Balance { get; set; }
        public Account() { }
        public Account(string name, string no,double balance) {
            AccName = name;
            AccNo = no;
            Balance = balance;
        }
        public void Deposit(double amount) {
            Balance += amount;
        }
        public void Withdraw(double amount) {
            if (amount <= Balance) {
                Balance -= amount;
            }
        }
        public void Transfer(double amount, Account receiver){
            if (amount <= Balance) {
                this.Balance -= amount;
                receiver.Balance += amount;
            }
        }

    }
}
