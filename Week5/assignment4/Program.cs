using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int counter = 0;
            int[] numbers = new int[20];
            do
            {
                Console.Write("Enter a number (0=stop): ");
                number = int.Parse(Console.ReadLine());
                numbers[counter] = number;
                counter++;
            } while (number != 0 && counter != 20); 

            Console.Write("\nEnter a searchvalue: ");
            int searchvalue = int.Parse(Console.ReadLine());
            int valuecounter = 0;
            for (int i = 0; i < 20; i++)
            {
                if (numbers[i] == searchvalue)
                {
                    valuecounter++;
                }
            }
            Console.WriteLine($"\nNumber of occurences of searchvalue ({searchvalue}) is: {valuecounter}");
            Console.ReadKey();
        }
    }
}
