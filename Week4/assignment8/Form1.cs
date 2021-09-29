using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncompare_Click(object sender, EventArgs e)
        {
            double enterednumber = double.Parse(txtnumber.Text);
            int adding = 0;
            double sum1 = 0;
            double sum2 = enterednumber * ( enterednumber + 1 ) / 2;
            for (int i = 0; i < enterednumber; i++)
            {
                adding++;
                sum1 += adding;
                
            }

            lblanswersum1.Text = ($"{sum1}");
            lblanswersum2.Text = ($"{sum2}");

            if (sum1 == sum2)
            {
                lblequalnumbers.Text = ("The sum and formula are equal.");
            }
            else
            {
                lblequalnumbers.Text = ("The sum and formula are not equal.");
            }

        }
    }
}
