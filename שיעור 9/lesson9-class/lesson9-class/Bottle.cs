using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9_class
{
    class Bottle
    {
        public bool plastic;
        public bool glass;
        public bool ifRecycle;

        public Bottle(bool plastic, bool glass)
        {
            this.plastic = plastic;
            this.glass = glass;
            ifRecycle = true;

        }


    }
}
