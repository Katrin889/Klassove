using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankovMetod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankAccound acc = new BankAccound();
            //acc.ID = 2;
            //acc.Deposit(200);
            //acc.Withdraw(20);
            //Console.WriteLine(acc.ToString());

            Dictionary<int, BankAccound> accounds = new Dictionary<int, BankAccound>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] parts = input.Split();
                string command = parts[0];
                int id = int.Parse(parts[1]);
                try
                {
                    switch (command)
                    {
                        case "Create":
                            if (!accounds.ContainsKey(id))
                                accounds[id] = new BankAccound(id);
                            else
                                Console.WriteLine("Accound already exists");
                            break;
                        case "Deposit":
                            double depositAmound = double.Parse(parts[2]);
                            if (accounds.ContainsKey(id))
                                accounds[id].Deposit(depositAmound);
                            else
                                Console.WriteLine("Accound already exists");
                            break;
                        case "Withdraw":
                            double withdrawAmound = double.Parse(parts[2]);
                            if (accounds.ContainsKey(id))
                                accounds[id].Deposit(withdrawAmound);
                            else
                                Console.WriteLine("Accound already exists");
                            break;
                        case "Print":
                            if (accounds.ContainsKey(id))
                                Console.WriteLine(accounds[id]);
                            else
                                Console.WriteLine("Accound already exists");
                            break;
                        default:
                            Console.WriteLine("Invalid command");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
