using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    class Store : Property
    {
        

      
        public double CalculateValue(double price, double squarMetters, int nWindow)
        {
            double endPrice = price;
            
            if (squarMetters > 50)
            {
                endPrice = endPrice + (endPrice * 0.01);
            }
            if (nWindow <= 1)
            {
                endPrice = endPrice - (endPrice * 0.02);
            }else if (nWindow > 4)
            {
                endPrice = endPrice + (endPrice * 0.02);
            }
            return endPrice;
        }

    }
}
