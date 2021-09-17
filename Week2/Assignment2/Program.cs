using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            double avarage = 0;     
            for(int i = 1; i < 4; i++)
            { //get 3 numbers
                Console.Write($"Enter number {i}: ");
                avarage = double.Parse(Console.ReadLine()) + avarage;
                if (i == 3)
                { // calculate avarage
                    avarage = avarage / 3; 
                }
            } // display avarage
            Console.WriteLine("The Avarage is: " + avarage); 

            Console.ReadKey();
        }
    }
}
