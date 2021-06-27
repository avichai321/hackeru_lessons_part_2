using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_4_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //int[] myarr1 = new int[5] {1,5,2,6,3};
            //int[,] myarr2 = new int[2, 3] { { 9, 5 ,8 }, { 4, 1 ,3} };
            //Console.WriteLine(myarr1.Length);
            //Console.WriteLine(myarr1.Rank);
            //Console.WriteLine(Array.IndexOf(myarr1 , 5));
            //Array.Sort(myarr1);
            //for (int i = 0; i < myarr1.Length; i++)
            //{
            //Console.Write(myarr1[i] + ",");
            //}

            //Console.WriteLine("\n" + myarr2.GetLength(0));
            #endregion

            #region 2
            //int[] gamearr = new int[10] { 1, 9, 8, 4, 6, 7, 3, 5, 2, 0 };
            //int guess;
            //int trys;
            //int win = 0;
            //int sum_trys = 0;
            //for (int i = 0; i < gamearr.Length; i++)
            //{
            //    trys = 0;
            //    while (trys != 30)
            //    {
            //        Console.WriteLine("\nEnter a number the {0} array value: ", i + 1);
            //        guess = int.Parse(Console.ReadLine());
            //        trys += 1;
            //        if (Array.IndexOf(gamearr, guess) != i)
            //        {
            //            Console.WriteLine("sorry wrong guess try again");
            //            continue;
            //        }
            //        else
            //        {
            //            Console.WriteLine("congratulation, you found the {0} value in the array after {1} guesses", i + 1, trys);
            //            win += 1;
            //            break;
            //        }
            //    }
            //    if (trys == 30)
            //    {
            //        Console.WriteLine("Game Over");
            //        break;
            //    }
            //    sum_trys += trys;
            //}
            //if (win == gamearr.Length)
            //{
            //    Console.WriteLine("\nyou finished the all game with {0} guesses in summery", sum_trys);
            //}
            #endregion

            #region 3
            //int[,] myarr_math = new int[5, 5] { { 1, 8, 6, 3, 4 }, { 2, 5, 9, 4, 0 }, { 5, 4, 6, 8, 9 }, { 8, 6, 9, 2, 3 }, { 2, 3, 8, 1, 5 } };
            //Console.WriteLine("Enter a number");
            //int search_num = int.Parse(Console.ReadLine());
            //for (int i = 0; i < myarr_math.GetLength(0); i++)
            //{
            //    for (int k = 0; k < myarr_math.GetLength(1); k++)
            //    {
            //        if (search_num == myarr_math[i, k])
            //        {
            //            Console.WriteLine("The following number is in row {0} and column {1}", i + 1, k + 1);
            //        }
            //    }
            //}
            #endregion

            #region 4
            //int[,] myarr_multi = new int[10, 10];
            //for (int i = 0; i < myarr_multi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myarr_multi.GetLength(1); j++)
            //    {
            //        myarr_multi[i, j] = (i + 1) * (j + 1);
            //        Console.Write(myarr_multi[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 5 
            //int[,] arr_sub = new int[3, 3] {{ 1, 0, 1 }, {0,1,1}, {1,1,0} };
            //int column, row;
            //int sum_check;
            //int try2 = 0;
            //while (true)
            //{
            //    sum_check = 0;
            //    for (int i = 0; i < arr_sub.GetLength(0); i++)
            //    {
            //        for (int k = 0; k < arr_sub.GetLength(1); k++)
            //        {
            //            if (arr_sub[i, k] == 1)
            //            {
            //                sum_check += 1;
            //            }
            //        }
            //    }
            //    if (sum_check != 0)
            //    {
            //        try2 += 1;
            //        Console.WriteLine("Enter a row number :");
            //        row = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Enter a column number :");
            //        column = int.Parse(Console.ReadLine());
            //        if (arr_sub[row-1, column-1] == 1)
            //        {
            //            Console.WriteLine("Boom");
            //            arr_sub[row-1, column-1] = 0;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Miss");
            //        }
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //    Console.WriteLine("in summury there was a {0} trys", try2);
            #endregion

            #region 6
            //int[,,] arr6 = new int[2, 2, 2];
            //for (int i = 0; i < arr6.GetLength(0); i++)
            //{
            //    for (int y = 0; y < arr6.GetLength(1); y++)
            //    {
            //        for (int k = 0; k < arr6.GetLength(2); k++)
            //        {
            //            Console.WriteLine("Enter number:");
            //            arr6[i, y, k] = int.Parse(Console.ReadLine());

            //        }
            //    }
            //}
            //for (int i = 0; i < arr6.GetLength(0); i++)
            //{
            //    for (int y = 0; y < arr6.GetLength(1); y++)
            //    {
            //        for (int k = 0; k < arr6.GetLength(2); k++)
            //        {
            //            Console.WriteLine(arr6[i, y, k]);


            //        }
            //    }
            //}
            #endregion

            #region 7
            //int[,] arr7 = new int[6, 4];
            //for (int i = 0; i < arr6.GetLength(0); i++)
            //{
            //    for (int y = 0; y < arr6.GetLength(1); y++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 8
            //int[][] arr8 = new int[4][];
            //arr8[0] = new int[2];
            //arr8[1] = new int[2];
            //arr8[2] = new int[2];
            //arr8[3] = new int[2];
            //for (int i = 0; i < arr8.Length; i++)
            //{
            //    for (int k = 0; k < arr8[i].Length; k++)
            //    {
            //        Console.WriteLine("Enter number: ");
            //        arr8[i][k] = int.Parse(Console.ReadLine());

            //    }
            //}
            //for (int i = 0; i < arr8.Length; i++)
            //{
            //    for (int k = 0; k < arr8[i].Length; k++)
            //    {
            //        Console.WriteLine(arr8[i][k]);

            //    }
            //}
            #endregion

            #region 9 
            //Console.WriteLine("Enter number of classes");
            //int num_of_class = int.Parse(Console.ReadLine());
            //int[][] classes = new int[num_of_class][];
            //int[] class_average = new int[num_of_class];
            //int high_avg=0 ,sum ,avg;

            //for (int i = 0; i < classes.Length; i++)
            //{
            //    Console.WriteLine("Enter number of student to the {0} class" , i+1);
            //    classes[i] = new int[int.Parse(Console.ReadLine())];
            //}
            //for (int i = 0; i < classes.Length; i++)
            //{
            //    for (int k = 0; k < classes[i].Length; k++)
            //    {
            //        Console.WriteLine("Enter a grade for a student in class {0} student number {1}" ,i+1 , k+1 );
            //        classes[i][k] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < classes.Length; i++)
            //{
            //    sum = 0;
            //    for (int k = 0; k < classes[i].Length; k++)
            //    {
            //        sum += classes[i][k]; 
            //    }
            //    avg = sum/classes[i].Length;
            //    class_average[i] = avg;
            //    if (avg > high_avg)
            //    {
            //        high_avg = avg;
            //    }
            //}
            //Console.WriteLine("the class the most high average is class {0} with average of {1}",(Array.IndexOf(class_average , high_avg)+1), high_avg);
            #endregion
        }


    }
}
