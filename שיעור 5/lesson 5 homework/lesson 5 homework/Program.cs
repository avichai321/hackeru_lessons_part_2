using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5_homework
{
    class Program
    {
        #region 8
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter number between 1-10");
        //    int num = int.Parse(Console.ReadLine());
        //    Printnumber(num);

        //}
        //public static void Printnumber(int number)
        //{
        //    switch (number)
        //    {
        //        case 1:
        //            Console.WriteLine("one");
        //            break;
        //        case 2:
        //            Console.WriteLine("two");
        //            break;
        //        case 3:
        //            Console.WriteLine("three");
        //            break;
        //        case 4:
        //            Console.WriteLine("four");
        //            break;
        //        case 5:
        //            Console.WriteLine("five");
        //            break;
        //        case 6:
        //            Console.WriteLine("six");
        //            break;
        //        case 7:
        //            Console.WriteLine("seven");
        //            break;
        //        case 8:
        //            Console.WriteLine("eight");
        //            break;
        //        case 9:
        //            Console.WriteLine("nine");
        //            break;
        //        case 10:
        //            Console.WriteLine("ten");
        //            break;
        //        default:
        //            Console.WriteLine("press only 1-10");
        //            break;
        //    }
        //}
        #endregion

        #region 9
        //static void Main(string[] args)
        //{
        //    PrintNumberto10();
        //    Console.WriteLine("Enter number");
        //    int num = int.Parse(Console.ReadLine());
        //    bool ten = PrintNumber(num);
        //    Console.WriteLine(ten);
        //}
        //public static bool PrintNumber(int num)
        //{
        //    for (int i = 0; i <= num; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    if (num > 10)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;

        //}
        //public static void PrintNumberto10()
        //{
        //    for (int i = 0; i <= 10; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        #endregion

        #region 10
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter number between 1-10");
        //    int num = int.Parse(Console.ReadLine());
        //    PrintNum(num);
        //}
        //public static void PrintNum (int num)
        //{
        //    if (num != 10)
        //    {
        //        Console.WriteLine("Enter number between 1-10");
        //        int chack = int.Parse(Console.ReadLine());
        //        PrintNum(chack);
        //    }

        //}
        #endregion

        #region 11
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter number: ");
        //    int num = int.Parse(Console.ReadLine());
        //    int result = itsPrime(num);
        //    Console.WriteLine(result);
        //}
        //public static int itsPrime(int num)
        //{
        //    int chaack = 0;
        //    for (int i = 1; i <=num; i++)
        //    {
        //        if(num%i==0)
        //        {
        //            chaack += 1;
        //        }
        //    }
        //    if (chaack>2)
        //    {
        //        return 0;
        //    }
        //    else
        //    {

        //    return 1;
        //    }
        //}
        #endregion

        #region 12
        //static void Main(string[] args)
        //{
        //    int[] myarr1 = new int[5] { 17, 13, 9, 4, 2 };
        //    chacckArray(myarr1);
        //}
        //public static void chacckArray(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        int counter = 0;
        //        for (int k = 1; k <= arr[i]; k++)
        //        {
        //            if (arr[i] % k == 0)
        //            {
        //                counter += 1;
        //            }
        //        }
        //        if (counter > 2)
        //        {
        //            Console.WriteLine(arr[i] + " its not prime");
        //        }
        //        else
        //        {
        //            Console.WriteLine(arr[i] + " its prime");
        //        }
        //    }
        //}
        #endregion

        #region 13
        //static void Main(string[] args)
        //{
        //    int[] myarr1 = new int[5] { 17, 13, 9, 4, 2 };
        //    int[] myarr2 = new int[5] { 15, 5, 6, 8, 6 };
        //    int result = CheckBiggerArray(myarr1, myarr2);
        //    Console.WriteLine(result);

        //}
        //public static int CheckBiggerArray(int[] arr1 , int[] arr2)
        //{
        //    int sum_arr1 = 0;
        //    int sum_arr2 = 0;

        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        sum_arr1+= arr1[i];
        //    }
        //    for (int i = 0; i < arr2.Length; i++)
        //    {
        //        sum_arr2 += arr2[i];
        //    }
        //    if (sum_arr1 > sum_arr2)
        //        return 1;
        //    else if (sum_arr1 == sum_arr2)
        //        return 0;
        //    else
        //        return -1;
        //}
        #endregion

        #region 14
        //static void Main(string[] args)
        //{
        //   int[,] myarr1 = CrateRandomMatrix();
        //    for (int i = 1; i <= 10; i++)
        //    {
        //    Check_If_Exist(myarr1);
        //    }
        //}
        //public static int[,] CrateRandomMatrix()
        //{
        //    int[,] Matrix2d = new int[10, 10];
        //    for (int i = 0; i < Matrix2d.GetLength(0); i++)
        //    {
        //        for (int k = 0; k < Matrix2d.GetLength(1); k++)
        //        {
        //            Matrix2d[i, k] = new Random().Next(1, 100); 
        //        }
        //    }
        //    return Matrix2d;
        //}
        //public static void Check_If_Exist(int [,] Matrix)
        //{
        //    int counter = 0;
        //    Console.WriteLine("Enter number to search in the matrix :");
        //    int num_in_matrix = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < Matrix.GetLength(0); i++)
        //    {
        //        for (int k = 0; k < Matrix.GetLength(1); k++)
        //        {
        //            if (Matrix[i,k] == num_in_matrix)
        //            {
        //                counter += 1;
        //            }
        //        }
        //    }
        //    if (counter >= 1)
        //    {
        //        Console.WriteLine("Exist");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Missing");
        //    }

        //}
        #endregion

        #region 15
        //static void Main(string[] args)
        //{
        //    int[] arr1 = new int[6] { 100, 5, 2, 15, 10, -5 };
        //    arr1 = sortArray2(arr1);
        //    PrintArray(arr1);

        //}
        //public static int[] sortArray(int[] arr)
        //{
        //   Array.Sort(arr);
        //    return arr;
        //}
        //public static int[] sortArray2(int[] arr)
        //{
        //    {
        //        int spot;
        //        int low_value;
        //        for (int i = 0; i < arr.Length - 1; i++)
        //        {
        //            for (int j = i + 1; j < arr.Length; j++)
        //            {
        //                if (arr[j] < arr[i])
        //                {
        //                    spot = Array.IndexOf(arr, arr[j]);
        //                    low_value = arr[i];
        //                    arr[i] = arr[spot];
        //                    arr[spot] = low_value;
        //                }
        //            }
        //        }
        //    }
        //    return arr;
        //}
        //public static void PrintArray(int[] arr)
        //{
        //    Console.WriteLine("Array values:");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine($"{i+1} : {arr[i]}");
        //    }
        //}
        #endregion
    }
}
