using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homwork_if_else_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter secret number: ");
            int secret = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter guess number: ");
            int guess = int.Parse(Console.ReadLine());
            while (secret != guess)
            {
                if (guess < secret)
                {
                    Console.WriteLine("small too");
                    Console.WriteLine("Enter guess number: ");
                    guess = int.Parse(Console.ReadLine());
                    continue;

                }
                else
                {
                    Console.WriteLine("big too");
                    Console.WriteLine("Enter guess number: ");
                    guess = int.Parse(Console.ReadLine());
                    continue;
                }
            }
            Console.WriteLine("bingo!");
        }
    }
}
