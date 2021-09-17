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
            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int number3 = int.Parse(Console.ReadLine());

            if (number1 > number3 && number2 > number3)
            {
                Console.WriteLine("The third number is the smallest of the threef");
            } else
            {
                Console.WriteLine("The third number is not the smallest of the three");
            }

            Console.ReadKey();
        }
    }
}
