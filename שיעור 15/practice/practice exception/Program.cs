using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_exception
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("Enter number");
                int num = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine($"something wrong please chack or contact system administrator");
            }

            Console.WriteLine("done");
        }
    }
}
