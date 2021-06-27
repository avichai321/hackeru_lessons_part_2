using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homwork_if_else_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 1;
            int sum = 1;
            Console.WriteLine("Enter number");
            int a = int.Parse(Console.ReadLine());
            while(b<=a)
            {
                sum *= b;
                b++;
            }
            Console.WriteLine("the azzeret of {0} is: {1}", a, sum);
        }
    }
}
