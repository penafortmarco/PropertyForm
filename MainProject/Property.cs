using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    abstract class Property
    {
        private string adress;
        private int years;
        private float sqm;

        protected Property()
        {
        }

        protected abstract double CalculateValue();

        
    }
}
