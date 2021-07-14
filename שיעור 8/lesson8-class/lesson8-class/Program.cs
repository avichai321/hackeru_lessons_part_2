using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8_class
{
    class Program
    {
        static void Main(string[] args)
        {
        #region 1
           
            PrintInTwoRows(true, false);
            
            #endregion

            #region 2
            //Calculator c1 = new Calculator();
            //Console.WriteLine(c1.Calc(2, 5, '+'));
            //Console.WriteLine(c1.Calc("60", "40", '-'));
            //Console.WriteLine(c1.Calc(50,25,'/'));


            #endregion

        }
        #region f 1
        public static void PrintInTwoRows(string value1, string value2)
        {
            Console.WriteLine($"{value1}\n{value2}");

        }

        public static void PrintInTwoRows(int value1, int value2)

        {
            Console.WriteLine($"{value1}\n{value2}");
        }

        public static void PrintInTwoRows(bool value1, bool value2)
        {
            Console.WriteLine($"{value1}\n{value2}");
        }
        #endregion

        #region f 2
        class Calculator
        {
           
            public int Calc(int num1 , int num2 , char op)
            {
                    switch (op)
                    {
                        case '+':
                            return num1 + num2;
                            

                        case '/':

                            return num1 / num2;
                            

                        case '-':
                            return  num1 - num2;
                            

                        case '*':
                            return num1 * num2;
                           

                    }
                return -00;
                
            }
        public  double Calc(double num1, double num2, char op)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;


                case '/':

                    return num1 / num2;


                case '-':
                    return num1 - num2;


                case '*':
                    return num1 * num2;


            }
            return -00;

        }

        public string Calc(string num1, string num2, char op)
        {
                int num3= int.Parse(num1);
                int num4 =int.Parse(num2);
            switch (op)
            {
                case '+':
                    return Convert.ToString(num3 + num4);


                case '/':

                    return Convert.ToString(num3 / num4);


                case '-':
                    return Convert.ToString(num3 - num4);


                case '*':
                    return Convert.ToString(num3 * num4);


            }
            return "-00";

        }
        #endregion
        }
    }
}
