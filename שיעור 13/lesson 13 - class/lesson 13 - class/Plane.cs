using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_13___class
{
    class Plane: IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("okay, push the power button");
        }

        public double GetAltitude()
        {
            return 50;
        }
    }
}
