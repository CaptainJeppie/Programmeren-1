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
            int number = 0;
            Console.Write("Enter target number: ");
            int checknumber = int.Parse(Console.ReadLine());
            int countnumberchecked = 0;


            do
            {
                Console.Write("Enter a number: ");
                number = int.Parse(Console.ReadLine());

                if (number == checknumber)
                {
                    countnumberchecked++;
                }

            } while (number != 0);


            Console.WriteLine($"Count of numbers equal to target number: {countnumberchecked}");

            Console.ReadKey();
        }
    }
}
