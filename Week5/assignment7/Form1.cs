using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Create an array with 6 elements of the type integer named 'dice'. Fill this array with the value zero (so
6 times). Generate a random number with a value between 1 and 6 (just like a dice) in a repetition
6000 times.
If the value is 1, increase the element 0 in the array by 1, the same applies to the values 2, 3, 4, 5 and
6. The dice[0] element indicates the number of times value 1 has occurred. Or in general: dice[x-1]
indicates the number of times that x has been thrown.
At the end of the repetition, show the contents of the array on your screen. If the dice is 100% random,
what output would you expect?
Comments:
- only use the clicked event under the command button 'Throw'
- to generate a value between 1 and 6, you must use min. 1 and max. 7 for 'Random.Next(…)'
*/



namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthrow_Click(object sender, EventArgs e)
        {
            int[] dice = new int[6];
            Random rnd = new Random();
            for (int i = 0; i < 6000; i++)
            {
                int nextdiceroll = rnd.Next(1,7);// create random dice
                dice[nextdiceroll - 1] += 1;// if number is 1 - 6 add 1 to the number it is ( nextdiceroll = 1 --> dice[0] + 1)
            }
            lblthrows.Text = "";
            for (int i = 0; i < dice.Length; i++)
            {
                lblthrows.Text += ($"Number of throws of value {i+1} = {dice[i]}\n"); // display all throws
            }
            

        }
    }
}
