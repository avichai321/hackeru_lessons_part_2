using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12_class
{
   public class Table
    {
        public string Color;
        private int price;
        public int Price { get{ return price; } private set {price=value;} }
        public string Manufacturer { get; } = "bamaba";
        int tprice = 50;
        
        public Table(string color)
        {
            Color = color;
            price = tprice;
        }
        
        

        
        
    }
}
