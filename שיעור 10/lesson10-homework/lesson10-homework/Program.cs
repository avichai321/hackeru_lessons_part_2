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
    }
}
