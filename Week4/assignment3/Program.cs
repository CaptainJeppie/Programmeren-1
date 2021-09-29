using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int numberofnumbers = 0;
            int sumnumbers = 0;

            do
            {
                Console.Write("Enter a number: ");
                number = int.Parse(Console.ReadLine());
                numberofnumbers++;

                if (numberofnumbers % 5 == 0)
                {
                    sumnumbers = sumnumbers + number;
                }


            } while (number != 0);


            Console.WriteLine($"Sum of 5th, 10th, 15th, ... number is: {sumnumbers}");

            Console.ReadKey();
        }
    }
}
