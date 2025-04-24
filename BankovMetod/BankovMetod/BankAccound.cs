using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovMetod
{
    internal class BankAccound
    {
        private int id;
        private double balance;
        //private int create;
        //private int print;
        //private int end;
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
        //public int Create
        //{
        //    get { return create; }
        //    set { create = value; }
        //}
        //public int Print
        //{
        //    get { return print; }
        //    set { print = value; }
        //}
        //public int End
        //{
        //    get { return end; }
        //    set { end = value; }
        //}
        public void Deposit(double amount)
        {
            if (amount < 0) throw new ArgumentException("Invalid deposit amound");
                this.balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount < balance) throw new InvalidOperationException("Insufficient balance");
                this.balance -= amount;
        }
    
        public override string ToString()
        {
            return $"Accound {this.id}, balance {this.balance}";
        }
        public BankAccound(int id)
        {
            ID = id;
            Balance = 0;
        }
    }
}
