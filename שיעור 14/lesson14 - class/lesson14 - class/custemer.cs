using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14___class
{
    class custemer
    {
        public void Orderdish()
        {
            Console.WriteLine("what dish you want (enter number):\n1.falafel\n2.shawarma\n3.bamba");
            int dish = int.Parse(Console.ReadLine());
            chef a = new chef();
            a.MakeDish(dish);
        }
    }
    class chef
    {
        public void MakeDish(int dish)
        {
            try
            {
               if (dish == 1)
                {
                    throw new PitaOutOfRangeExecption("pita is out of stock");
                }

            }

            catch (Exception x)
            {
                Console.WriteLine("no");
            }
           
            
           
        }
    }
}
