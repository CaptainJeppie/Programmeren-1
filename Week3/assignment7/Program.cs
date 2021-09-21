using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get weight length and gender
            Console.Write("Enter weight (kg): ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter length (cm): ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter gender (male/female): ");
            bool ismale = false;

            Gender:
            string gender = Console.ReadLine();
            if ( gender == "male" )
            {
                ismale = true;
            } else if ( gender == "female")
            {
                ismale = false;
            } else
            {
                Console.Write("Invalid gender try again: ");
                goto Gender;
            }

            //calculate bmi
            double bmi = weight / Math.Pow((length / 100), 2);


            //Display users bmi and other information
            if (ismale == true)
            {
                double healthyweightmin = 20 * (Math.Pow((length / 100), 2));
                double healthyweightmax = 25 * (Math.Pow((length / 100), 2));
                Console.WriteLine($"\nbmi-value: {bmi:0.0}\nnormal bmi-values (min .. max): 20 .. 25\nhealthy weight range: {healthyweightmin:0.0} .. {healthyweightmax:0.0}");
            } else
            {
                double healthyweightmin = 19 * (Math.Pow((length / 100), 2));
                double healthyweightmax = 24 * (Math.Pow((length / 100), 2));
                Console.WriteLine($"\nbmi-value: {bmi:0.0}\nnormal bmi-values (min .. max): 19 .. 24\nhealthy weight range: {healthyweightmin:0.0} .. {healthyweightmax:0.0}");
            }

            Console.ReadKey();
        }
    }
}
