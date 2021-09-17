using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DetermineVATButton_Click(object sender, EventArgs e)
        {
            const double VAT = 0.21;
            //enter price
            double price = Convert.ToDouble(PriceTextbox.Text);

            // Calculate VAT and endPrice
            double VATdisplay = VAT * price;
            double endprice = VAT * price + price;


            //Display the end price
            PriceAnswerLabel.Text = ($"{price:F2}");
            VATAnswerLabel.Text = ($"{VATdisplay:F2}");
            TotalAnswerLabel.Text = ($"{endprice:F2}");

        }
    }
}
