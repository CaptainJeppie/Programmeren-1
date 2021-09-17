using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculatevarage_Click(object sender, EventArgs e)
        {
            double avarage = double.Parse(txtNumber1.Text) + double.Parse(txtNumber2.Text) + double.Parse(txtNumber3.Text);
            avarage = avarage / 3;
            // display avarage
            lblAvarage.Text = ($"{avarage}");
        }
    }
}
