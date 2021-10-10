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
            if (rbStore.Checked)
            {
                String adrs = Convert.ToString(tbAdress);
                int squarMetters, price, windw;


                squarMetters = Convert.ToInt32(tbSqm.Text);
                price = Convert.ToInt32(basePrice.Text);
                windw = Convert.ToInt32(tbNumStore.Text);

                Store st1 = new Store();

                int finalPrice = (int)st1.CalculateValue(price, squarMetters, windw);

                labelFinalPrice.Text = "El valor final de la propiedad en la dirección" + st1.Adress + "\n" +
                    "es: " + finalPrice;

            }else if (rbDept.Checked)
            {
                String adrs = Convert.ToString(tbAdress);

                int nDept, price, ant;

                nDept = Convert.ToInt32(tbNumDept.Text);
                price = Convert.ToInt32(basePrice.Text);
                ant = Convert.ToInt32(tbAnt);

                Department dp1 = new Department();
                int finalPrice = (int)dp1.CalculateValue(price, ant, nDept);
                labelFinalPrice.Text = "El valor final de la propiedad en la dirección" + dp1.Adress + "\n" +
                   "es: " + finalPrice;
            }

        }

        private void tbAnt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbStoreChecked(object sender, EventArgs e)
        {
            tbNumDept.Enabled = false;
            tbNumDept.Text = null;
            tbNumStore.Enabled = true;
            tbAnt.Enabled = false;
            tbAnt.Text = null;
            tbSqm.Enabled = true;

        }

        private void rbDepartmentChecked(object sender, EventArgs e)
        {
            tbNumDept.Enabled = true;
            tbNumStore.Text = null;
            tbNumStore.Enabled = false;
            tbAnt.Enabled = true;
            tbSqm.Text = null;
            tbSqm.Enabled = false;

        }
    }
}
