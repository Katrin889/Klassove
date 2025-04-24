using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    internal class Person
    {
        private string name;
        private int age;
        private string city;
        private List<BankAccound> accounds = new List<BankAccound>();
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public List<BankAccound> Accounds
        {
            get { return accounds; }
            set { accounds = value; }
        }
        public double GetBalance()
        {
            return accounds.Sum(element => element.Balance);
        }
        public void IntroduceYourself()
        {
            Console.WriteLine("Здравейте! Аз съм {0} и съм на {1} години и живея в {2}.", name, age, city);
        }
    }
}
