using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();
            mycar.year = 2020;
            mycar.brand = "aoodi";

            Car mycar2 = new Car();
            mycar2.year = 2021;
            mycar2.brand = "Kia";
            Console.WriteLine(mycar2.brand);
        }
    }
    class Car
    {
        public int year;
        public string brand;
    }
}
