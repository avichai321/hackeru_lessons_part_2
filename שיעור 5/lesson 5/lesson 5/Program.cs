using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            PrintDate();
            int age = GetMyAge();
            Console.WriteLine(age);
            
            string name = GetMyName();
            Console.WriteLine(name);


            string f_name = Console.ReadLine();
            string l_name = Console.ReadLine();
            string fullname = GetFullName(f_name, l_name);
            Console.WriteLine(fullname);
        }
        
        public static void PrintDate()
        {
            Console.WriteLine( DateTime.Now);
        }

        public static string GetMyName()
        {
            return "avicii";
        }
        public static int GetMyAge()
        {
            return 24;
        }

        public static string GetFullName(string first , string last)
        {
            return first + " " + last;
        }



    }


}
