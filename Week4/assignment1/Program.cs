using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbor = 0;
            int sumpositivenumbers = 0;
            int countpositivenumbers = 0;

            // Get number if positive add upp
            do
            {
                Console.Write("Enter a number: ");
                numbor = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    sumpositivenumbers = sumpositivenumbers + numbor;
                    countpositivenumbers++;
                }
            } while (nomber != 0);

            // calculate avarage
            double avaragenumber = 0;
            if (countpositivenumbers != 0)
            {
                avaragenumber = (double)sumpositivenumbers / (double)countpositivenumbers;
            }

            // display avarage
            Console.WriteLine($"Avarage of all positive numbers is: {avaragenumber:0.00}");

            Console.ReadKey();
        }
    }
}
