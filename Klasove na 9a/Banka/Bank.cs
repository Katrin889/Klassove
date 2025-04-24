using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    internal class Bank
    {

        static void Main(string[] args)
        {
            Person first = new Person();
            Console.Write("Kak se kazvash? ");
            first.Name = Console.ReadLine();
            Console.Write("Godini: ");
            first.Age = int.Parse(Console.ReadLine());
            Console.Write("Ot: ");
            first.City = Console.ReadLine();

            BankAccound accound1 = new BankAccound();
            Console.Write("ID: ");
            accound1.ID = int.Parse(Console.ReadLine());
            int id = accound1.ID;
            Console.Write("Balance: ");
            accound1.Balance = int.Parse(Console.ReadLine());
            double balance = accound1.Balance;
            first.IntroduceYourself();
            accound1.Accound();

            BankAccound acc1 = new BankAccound();
            acc1.Balance = balance;
            Console.Write("Deposit: ");
            acc1.Deposit(double.Parse(Console.ReadLine()));
            Console.Write("Withdraw: ");
            acc1.Withdraw(double.Parse(Console.ReadLine()));
            acc1.ID = id;
            Console.WriteLine(acc1.ToString());
            Console.WriteLine();


            Person second = new Person();
            Console.Write("Kak se kazvash? ");
            second.Name = Console.ReadLine();
            Console.Write("Godini: ");
            second.Age = int.Parse(Console.ReadLine());
            Console.Write("Ot: ");
            second.City = Console.ReadLine();

            BankAccound accound2 = new BankAccound();
            Console.Write("ID: ");
            accound2.ID = int.Parse(Console.ReadLine());
            id = accound2.ID;
            Console.Write("Balance: ");
            accound2.Balance = int.Parse(Console.ReadLine());
            balance = accound2.Balance;
            second.IntroduceYourself();
            accound2.Accound();

            BankAccound acc2 = new BankAccound();
            acc2.Balance = balance;
            Console.Write("Deposit: ");
            acc2.Deposit(double.Parse(Console.ReadLine()));
            Console.Write("Withdraw: ");
            acc2.Withdraw(double.Parse(Console.ReadLine()));
            acc2.ID = id;
            Console.WriteLine(acc2.ToString());
            Console.WriteLine();
        }
    }
}
