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

            int year = 0;
            do
            {
                Console.Write("Enter year (0 is stop value): ");
                year = int.Parse(Console.ReadLine());
                if (year != 0 && year < 0)
                {
                    Console.WriteLine("Year must be positive!");
                }
                else
                {
                    bool leapyear = IsLeapYear(year);
                    if (leapyear)
                    {
                        Console.WriteLine($"{year} is a leap year.");
                    } else { Console.WriteLine($"{year} is not a leap year."); }
                }
            } while (year != 0);

            Console.ReadKey();
        }
        static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                return true;
            }
            return false;       
        }
    }
}
