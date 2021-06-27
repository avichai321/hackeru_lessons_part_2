using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_if_else_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a num 1");
            int a = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter num 2:");
            int b = int.Parse(Console.ReadLine());
            if (a%b == 0)
                Console.WriteLine("num1 can be divided by num 2 without a remnant");
            else
                Console.WriteLine("num1 canno't be divided by num 2 without a remnant");

        }
    }
}
