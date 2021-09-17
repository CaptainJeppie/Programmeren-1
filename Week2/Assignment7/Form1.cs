using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            txtEndkm.Clear();
            txtPricepkm.Clear();
            txtStartkm.Clear();
            lblAnswerpriceexclVAT.ResetText();
            lblAnswerpriceinclVAT.ResetText();
            lblAnswerVAT.ResetText();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const double VAT = 0.21;
            // get variables
            double startkm = double.Parse(txtStartkm.Text);
            double endkm = double.Parse(txtEndkm.Text);
            double pricepkm = double.Parse(txtPricepkm.Text);

            // calculate price excl VAT
            double priceexclvat = (endkm - startkm) * pricepkm;

            //calculate VAT
            double VATdisplay = VAT * priceexclvat;

            //calculate price incl VAT
            double Totalprice = priceexclvat + VATdisplay;


            //Display the answers
            lblAnswerpriceexclVAT.Text = ($"{priceexclvat:0.00}");
            lblAnswerVAT.Text = ($"{VATdisplay:0.00}");
            lblAnswerpriceinclVAT.Text = ($"{Totalprice:0.00}");

        }
    }
}
