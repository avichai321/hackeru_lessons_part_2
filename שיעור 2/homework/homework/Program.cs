using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region 1
            //for (int i = 2; i<=20 ;i++)
            //    if(i%2==0)
            //    {
            //    Console.WriteLine(i);
            //    }

            //#endregion

            //#region 2
            //int sum = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("Enter number: ");
            //    int k = Convert.ToInt32(Console.ReadLine());
            //    sum += k;
            //}
            //Console.WriteLine("the average of numbers is {0}", sum / 5);
            //#endregion

            //#region 3
            //do
            //{
            //    Console.WriteLine("Enter number 1: ");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter number 2: ");
            //    int b = int.Parse(Console.ReadLine());

            //    if (a == 0 || b == 0)
            //    {
            //        continue;
            //    }
            //    else if (a < 0 || b < 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("multiplay = {0} sum = {1}", a * b, a + b);
            //}
            //while (true);
            //#endregion

            #region 4
            for (int i = 9; i > 0; i--)
            {
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(k +"\t");
                }
                Console.WriteLine();
                
            }
            #endregion

            //#region 5 etgar
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int k = 1; k <= 10; k++)
            //    {
            //        Console.Write(i * k + "\t");
            //    }
            //    Console.Write("\n");
            //}
            //#endregion
        }


    }
}
