using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_if_else_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter num 1: ");
                int num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    sum += num;
                }
                else
                {
                    Console.WriteLine("sum of numbers is : {0}", sum);
                    break;
                }
            }
        }
    }
}
