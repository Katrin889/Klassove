
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Banka2
{
    
    internal class Person
    {
        private string name;
        private int age;
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
        public void Introduse()
        {
            Console.WriteLine( name + ": " + age);
        }
    }
}
