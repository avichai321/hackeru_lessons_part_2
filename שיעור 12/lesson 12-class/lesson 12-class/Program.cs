using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12_class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region properties
            Table t1 = new Table("blue");
            Console.WriteLine(t1.Price);
            Console.WriteLine(t1.Manufacturer);
            
            
            #endregion
        }
    }
}
