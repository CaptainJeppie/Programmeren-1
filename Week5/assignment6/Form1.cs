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
 * Asignment:
 * Twenty random numbers (random values between 0 and 500) are inserted in an array. These 
 * numbers are also printed. All numbers in the array are compared with one number entered 
 * (comparison number). If the value in the table is larger than or equal to that number, 
 * the value in the * array is increased by 10. If the value in the table is smaller than 
 * that number, the value in the array is decreased by 5. All new numbers are also printed.
 */
namespace assignment6
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[20];


    public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lbltablebefore.Text = "";//clearing labels because i put in spaces to be able to click on them
            lbltableafter.Text = "";
            Random number = new Random();
            for (int i = 0; i < 20; i++)
            {
                numbers[i] = number.Next(501);
                lbltablebefore.Text += ($"Element {i:00} = {numbers[i]}\n");//display all 20 Elements
            }
        }

        private void btncompare_Click(object sender, EventArgs e)
        {
            int comparenumber = int.Parse(txtcomparisonnumber.Text);
            for (int i = 0; i < 20; i++)
            {
                if (numbers[i] >= comparenumber) // add 10 if input number is higher or equal to table number
                {
                    numbers[i] += 10; 
                } 
                else if (numbers[i] < comparenumber)// subtract 5 if input is lower than table number
                {
                    numbers[i] -= 5;
                }
                lbltableafter.Text += ($"Element {i:00} = {numbers[i]}\n");//display all 20 Elements again
                btncompare.Enabled = false;
            }

        }
    }
}
