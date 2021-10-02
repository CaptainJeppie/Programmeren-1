using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Random number = new Random();
            int[] numbers = new int[20];
            for (int i = 0; i < 20; i++)
            {
                int randomnumber = number.Next(201);
                numbers[i] = randomnumber;
                total += randomnumber;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Element {i} is {numbers[i]}");
            }
            double average = (double)total / numbers.Length;
            Console.WriteLine($"\nThe average is: {average:0.00}\n");
            double difference = 0;
            for (int i = 0; i < 20; i++)
            {
                if (numbers[i] >= average)
                {
                    difference = numbers[i] - average;
                }
                else
                {
                    difference =  average - numbers[i];
                }

                Console.WriteLine($"Difference between average and element {i} is {difference:0.00}");
            }


            Console.ReadKey();
        }
    }
}
