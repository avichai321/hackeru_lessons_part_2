using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_13___class
{
    public abstract class Furniture
    {
        public string Color { get; set; }
        public string Type { get; set; }

        public void Break()
        {
            Console.WriteLine("lets break it all");
        }
        
        public abstract void Newfromikea();
        
        


    }
    class Table1 : Furniture
    {
        public Table1(string color, string type)
        {
            Color = color;
            Type = type;
        }

        public void Bringmetable()
        {
            Console.WriteLine("give me chair");
        }
        public override void Newfromikea()
        {
            Console.WriteLine("i have 2 legs");
        }


    }
    class Chair : Furniture
    {
        public Chair(string color, string type) 
        {
            Color = color;
            Type = type;
        }
        public void Bringmechair()
        {
            Console.WriteLine("give me chair");
        }

        public override void Newfromikea()
        {
            Console.WriteLine("i have 4 legs");
        }
    }
}
