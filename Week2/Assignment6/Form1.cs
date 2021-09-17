using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConverttime_Click(object sender, EventArgs e)
        {
            //Seconds 
            int seconds = int.Parse(txtSeconds.Text);

            //Seconds to min
            int min = seconds / 60;
            seconds = seconds % 60;
            //min to hours
            int hours = min / 60;
            min = min % 60;

            //Display the time
            lblAnswerhms.Text = ($"{hours:D2}:{min:D2}:{seconds:D2}");
        }
    }
}
