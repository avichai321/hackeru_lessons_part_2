using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leeson7_constrators_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 7
            //Car c1 = new Car("ford");
            //c1.GetBrand();
            #endregion
        }
    }
    class Car
    {
        public string _brand;
        
        public Car(string brand)
        {
            _brand = brand;
        }
        public void GetBrand()
        {
            Console.WriteLine(_brand);
        }
    }
}
