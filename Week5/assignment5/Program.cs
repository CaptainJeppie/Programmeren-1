using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1; //so manyy variables
            int[] preschoolers = new int[10];
            int numberofpreschoolers = 0;
            int totalagepreschoolers = 0;
            int[] children = new int[10];
            int numberofchildren = 0;
            int totalagechildren = 0;
            int[] adults = new int[10];
            int numberofadults = 0;
            int totalageadults = 0;
            do
            {
                Console.Write("Enter age (0=stop): ");
                number = int.Parse(Console.ReadLine());
                if (number > 0 && number <= 3)// preschoolers
                {
                    preschoolers[numberofpreschoolers] = number;
                    numberofpreschoolers++;
                    totalagepreschoolers += number;
                }
                else if (number >= 4 && number <= 17) //children
                {
                    children[numberofchildren] = number;
                    numberofchildren++;
                    totalagechildren += number;
                }
                else if (number >= 18) //adults
                {
                    adults[numberofadults] = number ;
                    numberofadults++;
                    totalageadults += number;
                }
                
               
            } while (number != 0);
            int oldestpreschooler = 0;//even more......
            int oldestchild = 0;
            int oldestadult = 0;

            Console.WriteLine($"\nPRESCHOOLERS"); //all preschoolers calculations
            for (int i = 0; i < numberofpreschoolers; i++)
            {
                Console.WriteLine($"Preschooler {i+1} is {preschoolers[i]} years old.");
                if (oldestpreschooler < preschoolers[i])
                {
                    oldestpreschooler = preschoolers[i];
                }
            }
            double average = (double)totalagepreschoolers / numberofpreschoolers;
            Console.WriteLine($"Average preschooler is {average:0.00} years old\nOldest preschooler is: {oldestpreschooler}");

            Console.WriteLine($"\nCHILDREN"); // all children calculations
            for (int i = 0; i < numberofchildren; i++)
            {
                Console.WriteLine($"Child {i + 1} is {children[i]} years old.");
                if (oldestchild < children[i])
                {
                    oldestchild = children[i];
                }
            }
            average = (double)totalagechildren / numberofchildren;
            Console.WriteLine($"Average child is {average:0.00} years old\nOldest child is: {oldestchild}");


            Console.WriteLine($"\nADULTS"); //all adults calculations
            for (int i = 0; i < numberofadults; i++)
            {
                Console.WriteLine($"Adult {i + 1} is {adults[i]} years old.");
                if (oldestadult < adults[i])
                {
                    oldestadult = adults[i];
                }
            }
            average = (double)totalageadults / numberofadults;
            Console.WriteLine($"Average child is {average:0.00} years old\nOldest child is: {oldestadult}");



            //don't work with more than 10 number in 1 array. + NaN error when no inputs lesgo > 2 lazy 2 fix
            Console.ReadKey();  
        }
    }
}
