using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1..4): ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("clubs");
                    break;
                case 2:
                    Console.WriteLine("diamonds");
                    break;
                case 3:
                    Console.WriteLine("hearts");
                    break;
                case 4:
                    Console.WriteLine("spades");
                    break;
                default:
                    Console.WriteLine("Incorrect number!");
                break;

            }


            Console.ReadKey();
        }
    }
}
