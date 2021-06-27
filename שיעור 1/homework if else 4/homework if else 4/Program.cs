using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_if_else_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int m = 2;
            Console.WriteLine("Enter num: ");
            int num = int.Parse(Console.ReadLine());
            while (num % m != 0 && m < num)
            {
                m++;
                counter++;
            }
            if (counter > 0)
            {
                Console.WriteLine("this is a prime number");
            }
            else
            {
                Console.WriteLine("this is not a prime number");
            }
        }
    }
}
