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

        public string Adress { get => adress; set => adress = value; }
    }
}
