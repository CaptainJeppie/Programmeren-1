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
            string allnumbers = "1, 1";
            int fibonaccinumber1 = 1;
            int fibonaccinumber2 = 1;
            int fibonaccinumber3 = 0;

            for (int i = 0; i < 18; i++)
            {
                fibonaccinumber3 = fibonaccinumber1 + fibonaccinumber2;
                allnumbers += ", " + fibonaccinumber3;
                fibonaccinumber1 = fibonaccinumber2;
                fibonaccinumber2 = fibonaccinumber3;
            }

            Console.WriteLine($"{allnumbers}");

            Console.ReadKey();
        }
    }
}
