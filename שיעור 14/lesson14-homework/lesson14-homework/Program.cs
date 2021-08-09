using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage gar = new Garage(new string[] { "den den moshi", "sunny", "merry" },3);

            gar.AddCar(new Car("sunny",false,true));
        }
    }
}
