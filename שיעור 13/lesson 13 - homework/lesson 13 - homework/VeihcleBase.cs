using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_13___homework
{
    abstract class VeihcleBase
    {
        protected VeihcleBase(string model, int numberOfWheels)
        {
            Model = model;
            NumberOfWheels = numberOfWheels;
        }

        public string Model { get; set; }
        public int NumberOfWheels { get; set; }

        public abstract void GetMaxNumOfPassangers();
        public abstract void GetMaxSpeed();

        public override string ToString()
        {
            return $"model: {Model} , Number of wheels: {NumberOfWheels} ";
        }

    }

    class Car : VeihcleBase
    {
        public Car(string model, int numberOfWheels, int numberOfDoors) : base(model, numberOfWheels)
        {
            NumberOfDoors = numberOfDoors;
        }

        public int NumberOfDoors { get; set; }
        public override void GetMaxNumOfPassangers()
        {
            Console.WriteLine("5 passengers");
        }

        public override void GetMaxSpeed()
        {
            Console.WriteLine("its over 9000!!!");
        }

        public override string ToString()
        {
            return base.ToString() + $" Number of doors: {NumberOfDoors}";
        }
    }

    class Motorcycle : VeihcleBase
    {
        public Motorcycle(string model, int numberOfWheels, int numberOfHandBrakes): base(model, numberOfWheels)
        {
            NumberOfHandBrakes = numberOfHandBrakes;
        }

        public int NumberOfHandBrakes { get; set; }
        public override void GetMaxNumOfPassangers()
        {
            Console.WriteLine("2 passengers");
        }

        public override void GetMaxSpeed()
        {
            Console.WriteLine("320 top speed");
        }
        public override string ToString()
        {
            return base.ToString() + $" Number of Hand Brakes: {NumberOfHandBrakes}";
        }
    }
    class Carrier
    {
        public VeihcleBase[] Vehicles { get; set; }
       
        public Carrier(VeihcleBase[] vehicles)
        {
            this.Vehicles = vehicles;
        }

        public override string ToString()
        {
            string start="";
            foreach (var i in Vehicles)
            {
                start += i+"\n";
            }
            
            return start;
        }
    }
}
