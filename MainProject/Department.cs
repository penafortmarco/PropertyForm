﻿using DotLiquid.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    class Department : Property
    {
        private int nDept;


        public Department(string adress, int years, float sqm, double price, int nDept) : base(adress, years, sqm, price)
        {
            
        }


        private double CalculateValue(double endPrice)
        {

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
