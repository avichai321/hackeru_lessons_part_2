using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2_targilfor
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region 1
            //Console.WriteLine("Enter number that higher then 3: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= num * 2; i++)
            //{
            //    if (i == 0)
            //    {
            //        continue;
            //    }
            //    if (i > num * 2)
            //        break;
            //    if (i == num * 2)
            //    {
            //        Console.WriteLine("End");
            //    }
            //    Console.WriteLine(i);
            //}
            //#endregion

            //#region 2
            //for (int i = 0, j = 10; i <= j; i++ , j--)
            //{
            //    Console.WriteLine(i+j);

            //}
            //#endregion

            #region 4
            int num1;
            int k = 0;
            do
            {
                Console.WriteLine("Enter any number except 23");
                num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 == 23)
                {
                    break;
                }
                k++;
            }
            while (true);
            Console.WriteLine(k);
            #endregion
        }
    }
}