using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //חזרה
            Console.WriteLine("Please enter a number: ");
            int x = int.Parse(Console.ReadLine());
            int i = 1;
            while (x < 20)
            {
                Console.WriteLine("run {0}: {1} ", i, x);
                if (x > 14 && x % 2 == 0)  
                {
                   int y = x / 2;
                    while (y > 0)
                    {
                        Console.WriteLine("half run {0}", y);
                        y--;
                    }
                }
                i++;
                x++;
            }
                
            

        }
    }
}
