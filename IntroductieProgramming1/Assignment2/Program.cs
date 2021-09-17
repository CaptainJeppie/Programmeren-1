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
            Console.Write("enter your age: ");
            int age = int.Parse(Console.ReadLine()) + 1;
            Console.WriteLine("Next year you will be " + age + " years old.");
            Console.ReadKey();
        }
    }
}
