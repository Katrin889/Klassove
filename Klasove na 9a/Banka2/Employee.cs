using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka2
{
    internal class Employee
    {
        private string name;
        private double zaplata;
        private string dluvnost;
        private string otdel;
        private string poshta;
        private int age;
        public string Name
        {get;set;}
            //get { return name; }
            //set { name = value; }
      // }
        public double Zaplata
        {
            get { return zaplata; }
            set { zaplata = value; }
        }
        public string Dluvnost
        {
            get { return dluvnost; }
            set { dluvnost = value; }
        }
        public string Otdel
        {
            get { return otdel; }
            set { otdel = value; }
        }
        public string Poshta
        {
            get { return poshta; }
            set { poshta = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void Data()
        {
            Console.WriteLine($"{name} {zaplata} {dluvnost} {otdel} {poshta} {age}");
        }
    }
}
