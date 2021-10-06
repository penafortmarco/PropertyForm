using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    abstract class Property
    {
        protected string adress;
        protected int years;
        protected float sqm;
        protected double price;

        protected Property(string adress, int years, float sqm, double price)
        {
            this.adress = adress;
            this.years = years;
            this.sqm = sqm;
            this.price = price;
        }
    }
}
