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
            //int myint;
            //MethodWithOut(out myint);
            //MethodWithRef(ref myint);

            #endregion

            #region in and params tirgul 

            #region 1
            //BuildSentence("I", "am", "Batman");
            #endregion

            #region 2
            //Person avicii = new Person("Avicii", 24);
            //Person daniel = new Person("Daniel", 27);
            //Person or = new Person("Or", 27);
            //Person avichai = new Person("Avichai", 24);
            //Person luffy = new Person("Luffy", 21);

            //avicii.PrintNameAndIncreaseAge(avicii, daniel, or, avichai, luffy);

            #endregion

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

        #region in and params tirgul
        #region 1
        public static void BuildSentence(params string[] sent)
        {
            for (int i = 0; i < sent.Length; i++)
            {
                Console.Write(sent[i] + " ");
            }
        }
        #endregion

        
        #endregion
    }
    #region 2 in and params tirgul

    class Person
    {
        public string name;
        public int age;

        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public void IncreaseAge(in Person p)
        {
            p.age++;
        }

        public void PrintNameAndIncreaseAge(params Person[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine($"The name of the person {p[i].name}");
                IncreaseAge(p[i]);
            }
        }
    }
    #endregion
}
