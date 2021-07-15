using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_8_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region stack and heap

            #region 5
            //int[] arr1 = new int[3] {1 ,5, 3};
            //int[] arr2 = new int[3];
            //int[] arr3 = new int[3];
            //arr3 = arr1;
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr2[i] = arr1[i];
            //}
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine($"arr1: {arr1[i]} arr2: {arr2[i]} arr3: {arr3[i]}");
            //}
            //arr2[0] = 6;
            //arr3[0] = 7;
            //Console.WriteLine();
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine($"arr1: {arr1[i]} arr2: {arr2[i]} arr3: {arr3[i]}");
            //}
            #endregion

            #endregion

            #region overloading
            #region 7
            // a-e
            //DigitalClock clock1 = new DigitalClock();
            //clock1.PrintHourAndMinute();
            //clock1.PrintHourMinuteAndSeconds();
            //clock1.PrintHourMinutSecondDayAndTemp();

            //Console.WriteLine();

            //clock1.PrintDetails(10, 05);
            //clock1.PrintDetails(10, 05, 58);
            //clock1.PrintDetails(10, 05, 58, 4, 35);
            #endregion

            #region 8

            //string[] arr = new string[2] { "avicii", "avichai" };
            //Computer c1 = new Computer(arr);
            //c1.TurnOff();
            //SmartComp c2 = new SmartComp();
            //c2.TurnOff();
            #endregion

            #endregion

            #region override and virtual and new
            #region 3
            //Vehicle onlyBase = new Vehicle();
            //Vehicle baseWithCar = new Car();
            //Vehicle baseWithMotor = new Motorcycle();
            //Car onlyCar = new Car();
            //Motorcycle onlyMotor = new Motorcycle();
            //onlyBase.AddWheel();
            //onlyBase.OpenOrCloseRoof();
            //Console.WriteLine();

            //baseWithCar.AddWheel();
            //baseWithCar.OpenOrCloseRoof();
            //Console.WriteLine();

            //baseWithMotor.AddWheel();
            //baseWithMotor.OpenOrCloseRoof();
            //Console.WriteLine();

            //onlyCar.AddWheel();
            //onlyCar.OpenOrCloseRoof();
            //Console.WriteLine();

            //onlyMotor.AddWheel();
            //onlyMotor.OpenOrCloseRoof();

            #endregion
            #endregion
        }

    }
    #region overloading
    #region 7
    class DigitalClock
    {
        public int hour;
        public int minute;
        public int second;
        public int day;
        public int temp;

        public DigitalClock()
        {

            DateTime date = new DateTime();
            this.hour = date.Hour;
            this.minute = date.Minute;
            this.second = date.Second;
            this.day = date.Day;
            this.temp = 25;
        }

        public void PrintHourAndMinute()
        {
            Console.WriteLine(hour + ":" + minute);
        }

        public void PrintHourMinuteAndSeconds()
        {
            Console.WriteLine(hour + ":" + minute + ":" + second);
        }

        public void PrintHourMinutSecondDayAndTemp()
        {
            Console.WriteLine(hour + ":" + minute + ":" + second + " day: " + day + " tempreture: " + temp);
        }

        //f
        public void PrintDetails(int hour, int minute)
        {
            Console.WriteLine(hour + ":" + minute);
        }
        public void PrintDetails(int hour, int minute, int second)
        {
            Console.WriteLine(hour + ":" + minute + ":" + second);
        }

        public void PrintDetails(int hour, int minute, int second, int day, int temp)
        {
            Console.WriteLine(hour + ":" + minute + ":" + second + " day: " + day + " tempreture: " + temp);
        }






    }

    #endregion

    #region 8
    class Computer
    {

        public string[] allOpenFiles;
        public bool isTurnOn;
        public Computer()
        {

        }

        public Computer(string[] allopenFiles)
        {
            this.allOpenFiles = allopenFiles;
            this.isTurnOn = false;
        }


        public void TurnOff()
        {
            allOpenFiles = null;
        }

        public void TurnOff(bool isturnon)
        {

            //return (isturnon == true || isturnon == false && allOpenFiles == null ? this.isTurnOn = false : this.isTurnOn=true);

            if (allOpenFiles == null)
            {
                TurnOff();
            }
            else
            {
                Console.WriteLine("are you sure?");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    TurnOff();
                }
            }
        }

    }

    class SmartComp : Computer
    {

        public string[] filesInCache;


        public SmartComp()
        {
            filesInCache = base.allOpenFiles;
        }

        public void TurnOff(bool isturnon, bool save)
        {
            if (isturnon)
            {
                if (save)
                {
                    if (allOpenFiles != null)

                    {
                        filesInCache = allOpenFiles;
                        TurnOff();


                    }
                    else
                    {
                        TurnOff();
                    }
                }
            }
            else
            {
                if (allOpenFiles != null)

                {
                    filesInCache = allOpenFiles;
                    TurnOff();

                }
            }
        }
    }

    #endregion
    #endregion

    #region override and virtual and new
    class Vehicle
    {
        public int numberOfWheels;
        public string color;
        public bool isTheRoofOpen;

        public virtual void AddWheel()
        {
            if (numberOfWheels < 4)
            {
                numberOfWheels += 1;
            }
            Console.WriteLine($"number of wheels : {numberOfWheels}");
        }

        public void OpenOrCloseRoof()
        {
            if (this.isTheRoofOpen)
            {
                this.isTheRoofOpen = false;
            }
            else
            {
                this.isTheRoofOpen = true;
            }

        }

    }
    class Car : Vehicle
    {

    }
    class Motorcycle : Vehicle
    {
        public override void AddWheel()
        {
            if (base.numberOfWheels < 2)
            {
                numberOfWheels += 1;
            }
            Console.WriteLine($"number of wheels : {numberOfWheels}");
        }

        public new void OpenOrCloseRoof()
        {
            Console.WriteLine("in the motorcycle the roof is always open");
        }
    }

    #endregion
}
