using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment8
{
    public partial class Form1 : Form
    {
        const double Pricetshirt = 30.00;
        const double Pricejeans = 100.00;
        const double VAT = 0.21;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get number of jeans and tshirts
            int nmbrshirts = int.Parse(txtNmbrshirts.Text);
            int nmbrjeans = int.Parse(txtNmbrjeans.Text);

            // calculate price
            double price = nmbrjeans * Pricejeans + nmbrshirts * Pricetshirt;
            double pricevat = VAT * price;
            double totalprice = pricevat + price;

           



            //display all
            lblAnswerdate.Text = DateTime.Now.ToString();
            lblAnswerprice.Text = price.ToString(("€ 0.00"));
            lblAnswervat.Text = pricevat.ToString(("€ 0.00"));
            lblAnswertotalprice.Text = totalprice.ToString(("€ 0.00"));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
