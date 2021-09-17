using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;


            Console.Write("Enter your name: ");

            name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is " + age);

            Console.ReadKey();

        }
    }
}
