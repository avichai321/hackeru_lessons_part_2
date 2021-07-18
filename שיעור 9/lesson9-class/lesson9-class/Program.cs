using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9_class
{
    class Program
    {
        static void Main(string[] args)
        {
            int howManyRecycled = 0;
            int maxRecycle = 5;
            Bottle[] arr = new Bottle[10];


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter type of bottle");
                Bottle b = new Bottle(Console.ReadLine());
                for (int k = 0; k <= maxRecycle; k++)
                {
                    b.recycle(ref howManyRecycled, maxRecycle);
                }
                arr[i] = b;
                howManyRecycled = 0;
            }

            

        }
    }
}
