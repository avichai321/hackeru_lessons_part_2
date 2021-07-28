using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_12__homework
{
    class Quotation
    {
        private int numOfLines;

        public string CustomerName { get; private set; }
        public double[] SumLines { get; set; }
        public double DocSum
        {
            get
            {
                double docsum = 0;
                for (int i = 0; i < SumLines.Length; i++)
                {
                    if (SumLines[i] == 0)
                    {
                        return docsum;
                    }
                    else
                    {
                        docsum = SumLines[i];
                    }
                }
                return docsum;
            }
        }
        public DateTime ValidUntil { get; private set; }

        public Quotation(int numOfLines, string customerName, DateTime validUntil)
        {
            CustomerName = customerName;
            this.numOfLines = numOfLines;
            SumLines = new double[numOfLines];
            ValidUntil = validUntil;
        }
        public static void ChangeMainDetails(Quotation p,string customerName, DateTime validUntil)
        {
            p.CustomerName = customerName;
            p.ValidUntil = validUntil;
        }
    }
}
