using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les4
{
    class Program
    {
        static void Main(string[] args)
        {
            namespace lesson_4
    {
        class Program
        {
            static void Main(string[] args)
            {
                #region 2dm array
                int[,] mydemarr = new int[10, 10];
                for (int i = 0; i < mydemarr.GetLength(0); i++)
                {
                    for (int j = 0; j < mydemarr.GetLength(1); j++)
                    {
                        mydemarr[i, j] = (i + 1) * (j + 1);
                        Console.Write(mydemarr[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                #endregion
            }
        }
    }
}

    }
}
