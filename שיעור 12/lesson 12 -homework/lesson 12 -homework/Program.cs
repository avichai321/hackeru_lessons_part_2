using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12__homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region properties
            //Quotation q = new Quotation(5, "avicii", new DateTime(2021, 12, 20));
            //q.SumLines[0] = 50;
            //Console.WriteLine(q.DocSum);
            //q.SumLines[1] = 60;
            //Console.WriteLine(q.DocSum);
            //Quotation.ChangeMainDetails(q,"luffy",new DateTime(2021, 12, 21));
            #endregion

            #region interfaces
            seaking a1 = new seaking();
            AnimalIsHungry(a1);
            #endregion
        }

        public static void AnimalIsHungry(lAnimal a)
        {
            if (a is IMakeSoundable)
            {
                (a as IMakeSoundable).MakeSoundBeforeEating();
            }
            else
            {
            a.Eat();
            }
        }

        public static void AnimalIsTiredy(lAnimal a)
        {
            a.Sleep();
        }
    }
}
