using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Etsy_Production_Data
{
    public class Product
    {
        public string name { get; set; }
        public double scale { get; set; }
        public double filament { get; set; }
        public double speed { get; set; }
        public double timeHrs { get; set; }
        public double timeMins { get; set; }
        public double materialCost { get; set; }
        public double sellPrice { get; set; }
        public double profit { get; set; }
        public double profitPerc { get; set; }

        public Product (string n, double s, double f, double sp, double tH, double tM, double mC, double sPrice, double p, double pP)
        {
            name = n;
            scale = s;
            filament = f;
            speed = sp;
            timeHrs = tH;
            timeMins = tM;
            materialCost = mC;
            sellPrice = sPrice;
            profit = p;
            profitPerc = pP;
        }
    }
}
