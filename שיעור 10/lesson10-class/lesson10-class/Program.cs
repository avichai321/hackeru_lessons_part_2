using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10_class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ref and out tirgul
            int myint;
            MethodWithOut(out myint);
            MethodWithRef(ref myint);

            #endregion
        }
        #region ref and out tirgul
        public static void MethodWithOut(out int num)
        {
            num = 2;
        }

        public static void MethodWithRef(ref int num)
        {

        }
        #endregion
    }
}
