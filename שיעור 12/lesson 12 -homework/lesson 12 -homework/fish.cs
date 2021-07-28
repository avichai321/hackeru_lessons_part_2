using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12__homework
{
    class fish : lAnimal
    {
        public void Eat()
        {
            Console.WriteLine("im hangry");
        }
        public void Sleep()
        {
            Console.WriteLine("leave me alone");
        }
        public void Move()
        {
            Console.WriteLine("okay okay");
        }
    }
}
