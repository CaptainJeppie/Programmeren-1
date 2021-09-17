using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int highestnumber = 0;
            int lowestnumber = 0;
            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2) {
                highestnumber = number1;
                lowestnumber = number2;
            }
            else
            {
                highestnumber = number2;
                lowestnumber = number1;
            }

            Console.WriteLine($"\nhighest value is: {highestnumber}\nlowest value is: {lowestnumber}");



            Console.ReadKey();
        }
    }
}
