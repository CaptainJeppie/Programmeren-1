using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int[] numbers = new int[20];
            for (int i = 0; i < 20; i++)
            {
                numbers[i] = number.Next(150);
                Console.WriteLine($"Element {i} = {numbers[i]}");
            }
            int lowestnumber = 10000;
            int occurence = 0;
            for (int i = 0; i < 20; i++)
            {
                
                if (lowestnumber >= numbers[i])
                {
                    lowestnumber = numbers[i];
                }
            }
            for (int i = 0; i < 20; i++)
            {
                if (lowestnumber == numbers[i])
                {
                    occurence++;
                }
            }

            Console.WriteLine($"\nSmallest number = {lowestnumber}\nnumber of occurence = {occurence}");


            Console.ReadKey();
        }
    }
}
