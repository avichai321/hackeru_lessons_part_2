using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9_class
{
    class Bottle
    {
        public string matirial;
        public bool ifRecycle;

        public Bottle(string matirial)
        {
            this.matirial = matirial;

        }
        public void recycle(ref int howManyRecycled, int maxRecycle)
        {
            if(this.matirial == "plastic" || this.matirial == "glass" )
            {
                if (howManyRecycled< maxRecycle)
                {
                    howManyRecycled++;
                    if (howManyRecycled== maxRecycle)
                    {
                        ifRecycle = true;
                    }
                }
            }
        }
    }
}
