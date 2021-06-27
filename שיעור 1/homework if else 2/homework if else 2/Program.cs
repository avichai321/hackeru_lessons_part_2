using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_if_else_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num 2: ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            double avg = sum / 2.0;

            Console.WriteLine("sum of the numbers: {0}, the avrage of the numbers: {1}" , sum, avg);
        }
    }
}
