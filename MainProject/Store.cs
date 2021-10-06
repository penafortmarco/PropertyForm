using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    class Store : Property
    {
        private int nWindow;

        public Store(string adress, int years, float sqm, double price, int nWindow) : base(adress, years, sqm, price)
        {

        }

        private double CalculateValue(double endPrice)
        {

            if (sqm > 50)
            {
                endPrice = endPrice + (endPrice * 0.1);
            }
            if (nWindow <= 1)
            {
                endPrice = endPrice - (endPrice * 0.2);
            }else if (nWindow > 4)
            {
                endPrice = endPrice + (endPrice * 0.2);
            }
            return endPrice;
        }

    }
}
