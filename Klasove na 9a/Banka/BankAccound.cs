using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    internal class BankAccound
    {
        private int id;
        private double balance;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Accound()
        {
            Console.WriteLine("ID {0} и баланс {1}", id, Balance);
        }
        public double Deposit(double amount)
        {
            this.balance += amount;
            return this.balance;
        }
        public double Withdraw(double amount)
        {
            this.balance = Balance - amount;
            return this.balance;
        }
        public override string ToString()
        {
            return $"Account {id}, balance {this.balance}";
        }
    }
}
