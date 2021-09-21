using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment9
{
    public partial class Form1 : Form
    {
        bool isfootball = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculatefee_Click(object sender, EventArgs e)
        {
            int age = int.Parse(txtage.Text);
            int membershipduration = int.Parse(txtmembership.Text);
            int price = 0;


            if (isfootball == true)
            {
                if (age > 40)
                {
                    if (membershipduration > 10)
                    {
                        lblfee.Text = ("€ 130.00");
                    }
                    else
                    {
                        lblfee.Text = ("€ 150.00");
                    }
                }
                else
                {
                    if (membershipduration > 10)
                    {
                        lblfee.Text = ("€ 155.00");
                    }
                    else
                    {
                        lblfee.Text = ("€ 175.00");
                    }
                }
            }else
            {
                if (age > 40)
                {
                    if (membershipduration > 10)
                    {
                        lblfee.Text = ("€ 180.00");
                    }
                    else
                    {
                        lblfee.Text = ("€ 200.00");
                    }
                }
                else
                {
                    if (membershipduration > 10)
                    {
                        lblfee.Text = ("€ 205.00");
                    }
                    else
                    {
                        lblfee.Text = ("€ 225.00");
                    }
                }
            }



        }

        private void rbtnfootball_CheckedChanged(object sender, EventArgs e)
        {
            isfootball = true;
        }

        private void rbtnhandball_CheckedChanged(object sender, EventArgs e)
        {
            isfootball = false;
        }
    }
}
