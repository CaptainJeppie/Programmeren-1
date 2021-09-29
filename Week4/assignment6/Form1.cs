using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6
{
    public partial class Form1 : Form
    {
        const double Annualintrest = 1.05;
        const double Years = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculatecapital_Click(object sender, EventArgs e)
        {
            double finalcapital = double.Parse(txtstartamount.Text);
            for (int i = 0; i < Years; i++)
            {
                finalcapital = finalcapital * Annualintrest;
            }
           

            lblendprice.Text = ($"€ {finalcapital:0.00}");

        }
    }
}
