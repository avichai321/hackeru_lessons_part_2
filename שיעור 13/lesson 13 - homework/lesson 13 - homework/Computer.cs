using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_13___homework
{
    static class Computer
    {
        static public string Type { get; set; }

        static Computer()
        {
            Type = "Im Static Class";
            Console.WriteLine(Type);
        }
        static void on()
        {
            Console.WriteLine("its on");
        }

        static void off()
        {
            Console.WriteLine("its off");
        }
    }
}
