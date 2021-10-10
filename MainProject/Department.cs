using DotLiquid.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    class Department : Property
    {
        public double CalculateValue(double price, int years, int nDept)
        {
            double endPrice = price;
            if (years<15)
            {
                endPrice = endPrice + (endPrice * 0.1);
            } else if (years > 15)
            {
                endPrice = endPrice - (endPrice * 0.2);
            }

            if (nDept >= 3)
            {
                endPrice = endPrice + (endPrice * 0.3);
            }
            return endPrice;
        }
    }
}
