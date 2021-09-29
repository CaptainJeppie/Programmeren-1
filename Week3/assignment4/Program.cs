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
            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int number3 = int.Parse(Console.ReadLine());

            //calculate all
            int sum = number1 + number2 + number3;
            double average = (double)sum / 3;
            int product = number1 * number2 * number3;
            int[] numbers = new int[3] {number1, number2, number3};
            int min = numbers.Min();
            int max = numbers.Max();


            //display all
            Console.WriteLine($"sum = {sum} \naverage = {average:0.00} \nproduct = {product} \nhighest = {max} \nlowest = {min}");

            Console.ReadKey();
        }
    }
}
