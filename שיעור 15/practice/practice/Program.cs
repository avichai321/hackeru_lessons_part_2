using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //cat c1 = new cat();
            //dog d1 = new dog();
            //c1.drink();
            //d1.drink();
            //d1.Name = "sdfc";
            //Console.WriteLine(d1.Name);
            //chack(c1);
            //chack(d1);


        }

        public static void chack(Ianimal a)
        {
            if (a is Idrink)
            {
                (a as Idrink).needdrink();
            }
            else
            { 
                a.drink();
            }
        }

    }
    interface Ianimal
    {
        int Age { get; set; }
        void drink();
        void eat();
        void sleep();
    }
    interface Idrink :Ianimal
    {
        void needdrink();
    }

    class cat :Idrink
    {
        public int Age { get;  set; }

        public void drink()
        {
            Console.WriteLine("thank you");
        }

        public void eat()
        {
            Console.WriteLine("nooooooooooooo");
        }

        public void needdrink()
        {
            Console.WriteLine("tavie tbira");
        }

        public void sleep()
        {
            Console.WriteLine("good night");
        }
    }

    class dog : Ianimal
    {
        string name;
        public string Name { get;  set;}
        public int Age { get; set; }

        public void drink()
        {
            Console.WriteLine("nooooooo");
        }

        public void eat()
        {
            Console.WriteLine("give me snizel");
        }

        public void sleep()
        {
            Console.WriteLine("noooooooooooooooooooooooooooo");
        }

        public string Getname()
        {
            return name;
        }
        public void Setname(string name)
        {
            this.name = name;
        }
    }


}
