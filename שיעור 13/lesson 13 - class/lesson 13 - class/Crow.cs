using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_13___class
{
    class Crow : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("okay, i going up");
        }

        public double GetAltitude()
        {
            return 35.5;
        }
    }
}
