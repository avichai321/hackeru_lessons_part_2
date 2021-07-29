using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_13___class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region interface
            //Plane p1 = new Plane();
            //Crow c1 = new Crow();
            //Fly(p1);
            //Fly(c1);
            #endregion

            #region abstruct
            #region 1 
            //FileMannager.Erasefile();
            //FileMannager.Readfile();
            //FileMannager.Savefile();
            #endregion
            #region 2
            //Table1 t1 = new Table1("brown", "oren");
            //t1.Break();
            //t1.Newfromikea();
            //Chair c1 = new Chair("black", "alon");
            //c1.Break();
            //t1.Newfromikea();
            #endregion

            #region 3
            //FormulaForAtom a = new FormulaForAtom();
            //a.clac();
            #endregion
            #endregion

        }
        #region interface
        public static void Fly(IFlyable fly)
        {
            fly.Fly();
        }

        public static void ati(IFlyable fly)
        {
            fly.GetAltitude();
        }
        #endregion
    }
}
