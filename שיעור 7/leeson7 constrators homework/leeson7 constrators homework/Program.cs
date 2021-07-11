using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leeson7_constrators_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 7
            //Car c1 = new Car("ford");
            //c1.GetBrand();
            #endregion

            #region 8
            //ConsolePlus Val1 = new ConsolePlus();
            //ConsolePlus val2 = new ConsolePlus("bamba" , 4 , 2);
            #endregion

            #region 9
            //Console.WriteLine("Enter array size: ");
            //int range = int.Parse(Console.ReadLine());
            //string[] names = new string[range];
            //int[] ages = new int[range];
            //Random age1 = new Random();
            //for (int i = 0; i < range; i++)
            //{
            //    Console.WriteLine("Enter name: ");
            //    Person p1 = new Person(Console.ReadLine());
            //    names[i] = p1._Name;
            //    Person p2 = new Person(names[i], age1.Next(1 , 101));
            //    ages[i] = p2._age;

            //}
            //for (int i = 0; i <range; i++)
            //{ 
            //    Console.WriteLine($"Name: {names[i]}\nAge: {ages[i]}");
               
            //}
            #endregion

            #region 10 challenge
            Anime show1 = new Anime("Naruto shippuden", 700, "Naruto");
            Anime show2 = new Anime(show1);
            Anime show3 = new Anime("one piece", 980, "luffy");
            Anime show4 = show3;
            
            #endregion
        }
    }
    public class Car
    {
        public string _brand;

        public Car(string brand)
        {
            _brand = brand;
        }
        public string GetBrand()
        {
            return _brand;
        }
    }

    public class ConsolePlus

    {
        public ConsolePlus()
        {
            Console.WriteLine("default");
        }

        public ConsolePlus(string value) : this()
        {
            Console.WriteLine(value);
        }

        public ConsolePlus(string value, int num1, int num2) : this(value)
        {
            Console.WriteLine(num1 + num2);
        }

    }

    public class Person
    {
        public string _Name;
        public int _age;

        public Person(string name)
        {
            _Name = name;
        }
        public Person(string name, int age) : this(name)
        {
            _age = age;
        }
    }

    public class Anime
    {
        public string _ShowName;
        public int _NumberOfEpiosdes;
        public string _MainCharecrter;

        public Anime(string ShowName, int numberofepisodes, string Maincharecter)
        {
            _ShowName = ShowName;
            _NumberOfEpiosdes = numberofepisodes;
            _MainCharecrter = Maincharecter;
        }
        public Anime(Anime anime)
        {
            _ShowName = anime._ShowName;
            _NumberOfEpiosdes = anime._NumberOfEpiosdes;
            _MainCharecrter = anime._MainCharecrter;

        }
     


    }
}
