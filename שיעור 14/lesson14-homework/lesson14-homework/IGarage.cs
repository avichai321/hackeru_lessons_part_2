using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14_homework
{
    interface IGarage
    {
        void AddCar(Car car);
        void TakeOutCar();
        void FixCar();
    }
}
