using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            int result = number + number;

            result = result + 10;

            result = result / 2;
            result = result - int.Parse(input);


            Console.WriteLine($"results is {result}");

            Console.ReadKey();

        }
    }
}
