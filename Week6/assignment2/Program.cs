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
            int number;
            do
            {
                Console.Write("Enter number (0 is stop value): ");
                number = int.Parse(Console.ReadLine());
                if (number > 0) {
                    bool primenumber = IsPrimeNumber(number);
                    if (primenumber)
                    {
                        Console.WriteLine($"{number} is a prime number.");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is not a prime number.");
                    }
                }
                else if(number < 0)
                {
                    Console.WriteLine("Negative number entered...");
                }
            } while (number != 0);
            Console.WriteLine("End of program");
            Console.ReadKey();
        }

        static bool IsPrimeNumber(int number)
        {
            if (number == 2) { return true; }
            if (number == 1 || number % 2 == 0) { return false; } 
            int sqrt = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (number % i == 0) { return false; } 
            }
            return true;
        }
    }
}
