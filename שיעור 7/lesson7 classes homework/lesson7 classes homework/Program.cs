using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7_classes_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 8
            //Computer c1 = new Computer();
            //c1._model = "hp";
            //c1.TellMeYourPrice(500);
            //c1.TellMeYourScreenSize(50);
            //c1._NumberOfProcessors = 4;
            //c1.addProcessor();
            //c1.turnOn();
            //c1.turnOff();
            //Console.WriteLine(c1.overide());

            //Computer c2 = new Computer();
            //c2._model = "Dell";
            //c2.TellMeYourPrice(1500);
            //c2.TellMeYourScreenSize(24);
            //c2._NumberOfProcessors = 3;
            //c2.addProcessor();
            //c2.turnOn();


            //Computer c3 = new Computer();
            //c3._model = "Asus";
            //c3.TellMeYourPrice(1000);
            //c3.TellMeYourScreenSize(24);
            //c3._NumberOfProcessors = 1;
            //c3.addProcessor();
            //c3.turnOn();
            //c3.turnOff();
            //Console.WriteLine(c3.ToString());
            #endregion

            #region 9
            // שולחן 1 הגדרה רגילה
            //Table T1 = new Table();
            //T1._numberOfLegs = 4;
            //T1._color = "Brown";
            //T1._typeOfTree = "Alon";

            //// שולחן 2 הגדרה עם בנאי
            //Table T2 = new Table(4, "Brown", "Alon");

            ////שולחן 3 אובג'גט אנליישיייזר
            //Table T3 = new Table
            //{
            //    _numberOfLegs = 4,
            //    _color = "Brown",
            //    _typeOfTree = "Alon"
            //};

            ////שולחן 4 ששוה לשולחן 2
            //Table T4 = T2;

            //T4._numberOfLegs = 5;
            //T2._color = "Black";
            #endregion

            #region 10
            //Octagon O1 = new Octagon(5, 6);
            #endregion

        }
    }
    public class Computer
    {
        public string _model;
        public int _price;
        public int _NumberOfProcessors;
        public float _ScreenSize;
        public bool _IsTurnOn;

        public void TellMeYourPrice(int price)
        {
            _price = price;
        }

        public void TellMeYourScreenSize(float screensize)
        {
            _ScreenSize = screensize;
        }

        public void turnOn()
        {
            _IsTurnOn = true;
        }

        public void turnOff()
        {
            _IsTurnOn = false;
        }
        public void addProcessor()
        {
            _NumberOfProcessors += 1;
        }

        public string overide()
        {
            return ToString();
        }

    }

    public class Table
    {
        public int _numberOfLegs;
        public string _color;
        public string _typeOfTree;
        
        public Table()
        {

        }

        public Table(int numberOflegs, string color, string typeoftree)
        {
            _numberOfLegs = numberOflegs;
            _color = color;
            _typeOfTree = typeoftree;
        }
    }

    public class Octagon
    {
        public double _area;
        public double _scope;

        public Octagon(int length, int width)
        {
            _area = GetArea(length, width);
            _scope = GetScope(length, width);
        }
            double GetArea(int length ,int width)
            {
                return length * width; 
            }

            double GetScope(int length, int width)
            {
                return (length * 2) + width * 2;
            }
    }
}
