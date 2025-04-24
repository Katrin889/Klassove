using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasove_na_9a
{
    internal class Person
    {
        private string name;
        private int age;
        private string city;
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

        public void IntroduceYourself()
        {
            Console.WriteLine("Здравейте! Аз съм {0} и съм на {1} години и живея в {2}.", name, age, city);
        }

    }
}
