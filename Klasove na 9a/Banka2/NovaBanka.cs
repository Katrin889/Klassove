using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Banka2
{
    internal class NovaBanka
    {
        static void Main(string[] args)
        {
            //Type personType = typeof(Person);
            //FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            //Console.WriteLine(fields.Length);

            Console.Write("How many impoyees are you entering? ");
            int n = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[n];

            string[] name = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Name: ");

                employees[i].Name = Console.ReadLine();

                Console.Write("Zaplata: ");

                employees[i].Zaplata = double.Parse(Console.ReadLine());
                Console.Write("Dluvnost: ");

                employees[i].Dluvnost = Console.ReadLine();
                Console.Write("Otdel: ");

                employees[i].Otdel = Console.ReadLine();
                Console.Write("Poshta: ");

                employees[i].Poshta = Console.ReadLine();
                Console.Write("Age: ");

                employees[i].Age = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < n; i++)
            {
                employees[i].Data();
            }
        }
    }
}
