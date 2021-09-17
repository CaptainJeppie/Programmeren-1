using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Seconds 
            Console.Write("Enter number of seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            //Seconds to min
            int min = seconds / 60;
            seconds = seconds % 60;

            //min to hours
            int hours = min / 60;
            min = min % 60;

            //Display the time
            Console.WriteLine($"{hours:D2}:{min:D2}:{seconds:D2}");

            Console.ReadKey();
        }
    }
}
