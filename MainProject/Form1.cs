using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            String adrs = Convert.ToString(tbAdress);
            int yrs, squarMetters, price, windw;

            yrs = Convert.ToInt32(tbAnt);
            squarMetters = Convert.ToInt32(tbSqm);
            price = Convert.ToInt32(basePrice);
            windw = Convert.ToInt32(tbNumStore);

            Store st1 = new Store(adrs, yrs, squarMetters, price, windw);

            

            



        }

        private void tbAnt_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
