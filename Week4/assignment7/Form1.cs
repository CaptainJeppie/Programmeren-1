using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sidelength = int.Parse(txtsidelength.Text);
            string square = "";
            int row = 0;
            for (int i = 0; i < sidelength; i++)
            {
                square += "\nx";// next line
                row++;
                for (int o = 0; o < sidelength - 2; o++) //subtract 2 for the x's added in the beginning and the end
                {
                    if (row == sidelength || row == 1)// first and last row all x
                    {
                        square += "x";
                    } else
                    {
                        square += " ";;// in between first and last row all space
                    } 
                }
                square += "x";// add an x to every line
            }


            //display square
            lblsquare.Text = square;


        }
    }
}
