using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasove_na_9a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            Console.Write("Kak se kazvash? ");
            firstPerson.Name = Console.ReadLine();
            Console.Write("Godini: ");
            firstPerson.Age = int.Parse(Console.ReadLine());
            Console.Write("Ot: ");
            firstPerson.City = Console.ReadLine();
            firstPerson.IntroduceYourself();
            Person secondPerson = new Person();
            secondPerson.Name = "Пламен";
            secondPerson.Age = 16;
            secondPerson.City = "Хисар";
            secondPerson.IntroduceYourself();
        }
    }
}
