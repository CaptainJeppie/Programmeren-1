using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            //get working hours, years, failures
            Console.Write("Enter number of working hours: ");
            int workinghours = int.Parse(Console.ReadLine());

            Console.Write("Enter number of years: ");
            int years = int.Parse(Console.ReadLine());

            Console.Write("Enter number of failures: ");
            int failures = int.Parse(Console.ReadLine());

            //compare working hours, years, failures to max
            if (workinghours > 10000 || years >= 7 || failures > 25)
            {
                Console.WriteLine("\nMachine needs to be replaced.");
            } else
            {
                Console.WriteLine("\nMachine does not need to be replaced.");
            }


            Console.ReadKey();
        }
    }
}
