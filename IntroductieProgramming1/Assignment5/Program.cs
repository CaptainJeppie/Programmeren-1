using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hoeveel getallen wil je hebben?");
            int repeat = int.Parse(Console.ReadLine());


            string som = ""; 
            int output = 0;
            Random rnd = new Random();
            for (int i = 0; i < repeat; i++) {
                int number = rnd.Next(101, 10000);
                Console.WriteLine(number);
                output = output + number;
                som = som + Convert.ToString(number);
                if (i < repeat - 1)
                {
                    som = som + " + ";
                }
            }   
            if (Console.ReadLine() == Convert.ToString(output)) 
            {
                Console.WriteLine("thats right!");
                Console.WriteLine("The Result: " + som + " = " + output);
            } else
            {
                Console.WriteLine("Wrong the answer was: " + output);
                Console.WriteLine("The Result: " + som  + " = " + output);
            }

            

            Console.ReadKey();
        }
    }
}
