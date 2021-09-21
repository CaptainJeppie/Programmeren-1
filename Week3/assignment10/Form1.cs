using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment10
{
    public partial class Form1 : Form
    {
        const int Baseprice = 12;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = int.Parse(txtage.Text);
            int ticketprice= 0;

            if (age >= 5 && age <= 12)
            {
                ticketprice = Baseprice / 2;
            }
            else if (age >= 13 && age <= 54)
            {
                ticketprice = Baseprice;
            }

            lblticketprice.Text = ($"€ {ticketprice:0.00}");

        }
    }
}
