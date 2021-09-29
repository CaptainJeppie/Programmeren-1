using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            do
            {
                Console.Write("Enter a year: ");
                year = int.Parse(Console.ReadLine());


                if (year != 0 && year % 4 == 0 )
                {
                    Console.WriteLine($"{year} is a leap year.");
                } else if (year != 0 && year > 0)
                {
                    Console.WriteLine($"{year} is not a leap year.");
                }
                else if (year != 0)
                {
                    Console.WriteLine("Year must be positive!");
                }

            } while (year != 0);


            Console.ReadKey();
        }
    }
}
