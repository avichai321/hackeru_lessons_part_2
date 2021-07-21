using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ref and out

            #region 2
            //int a = 5;
            //int b = 6;
            //calculation(ref a, ref b);
            //Console.WriteLine($"a: {a} b: {b}");
            #endregion

            #region 3 
            //int a;
            //int b;
            //out2(out a, out b);
            //Console.WriteLine($"a: {a} b: {b}");
            #endregion

            #region 4
            //bool ifOkey;
            //string errorMessage;
            //ValidateValues("avichai","dahan","456336859","134356132",25,out ifOkey, out errorMessage);
            //Console.WriteLine(ifOkey);
            //Console.WriteLine(errorMessage);
            #endregion


            #endregion

            #region params and in names and optional args
            #region 1
            //Console.WriteLine(calculate(5,2,3)); 
            #endregion

            #region 2
            //abc(5,3,3);
            #endregion

            #region 3
            //abc(a: 1, c: 10);
            #endregion

            #region 4
            //Console.WriteLine(function_D(3));
            #endregion

            #region 5
            //Phone p1 = new Phone();
            //Phone p2 = new Phone(screensize : 7, model: "oneplus");
            //Phone p3 = new Phone(camerapixel: 67, battery: "lipo");
            //Phone p4 = new Phone(screensize: 7, model: "oneplus nord", camerapixel: 32);

            #endregion
            #endregion
        }

        #region ref and out

        #region 2
        public static void calculation(ref int a, ref int b)
        {
            a++;
            b *= 2;
        }
        #endregion

        #region 3
        public static void out2(out int a, out int b)
        {
            a = 2;
            b = 3;
        }
        #endregion

        #region 4
        public static void ValidateValues(string firstName, string lastName, string cellPhone, string ID, int age, out bool ifOkey, out string errorMessage)
        {
            ifOkey = true;
            errorMessage = "everthing is ok";

            if (string.IsNullOrEmpty(firstName)|| string.IsNullOrEmpty(lastName))
            {
                errorMessage = "first name or last name is empty";
                ifOkey = false;
            }

            if (cellPhone.Length <9 || !cellPhone.StartsWith("0"))
            {
                errorMessage = "phone number is not synced";
                ifOkey = false;
            }
            if (ID.Length < 9 || ID.Length > 9)
            {
                errorMessage = "wrong ID";
                ifOkey = false;
            }
            if (age < 0 || age > 100)
            {
                errorMessage = "not valid age";
                ifOkey = false;
            }


        }
        #endregion
        #endregion

        #region params and in names and optional args
        #region 1
        public static int calculate(params int[] nums)
        {
            int mid_num=1;
            int sum_num = 0;
            for (int i = 0 ; i < nums.Length; i++)
            {
                for (int k = 1; k <=i+1; k++)
                {
                    mid_num = nums[i] * mid_num;
                }
                sum_num += mid_num;
                mid_num = 1;
            }
            return sum_num;
        }

        #endregion

        #region 2 3
        public static void abc(int a, int b = 1 ,int c = -1)
        {
            Console.WriteLine(a * b * c); 
        }
        #endregion

        #region 4
        public static int function_D(in int num)
        {
            int multiply = num * 3;
            return multiply;
        }
        #endregion

       
        #endregion

    }
    #region params and in names and optional args
    #region 5
    class Phone
    {
        int screenSize;
        string Model;
        string Battery;
        int cameraPixels;

        public Phone(int screensize = 6 , string model = "samsung" , string battery = "lion", int camerapixel = 50)
        {
            screenSize = screensize;
            Model = model;
            Battery = battery;
            cameraPixels = camerapixel;
        }
    }
    #endregion
    #endregion
}
