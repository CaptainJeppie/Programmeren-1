using System;

namespace assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            //get score
            Console.Write("Enter score: ");
            int gradenumber = int.Parse(Console.ReadLine());
            //Test if user passed
            if (gradenumber >= 90 && gradenumber <= 100)
            {
                Console.WriteLine("grade: A\ncourse passed");
            } 
            else if (gradenumber >= 80 && gradenumber < 90)
            {
                Console.WriteLine("grade: B\ncourse passed");
            }
            else if (gradenumber >= 70 && gradenumber < 80)
            {
                Console.WriteLine("grade: C\ncourse passed");
            }
            else if (gradenumber >= 60 && gradenumber < 70)
            {
                Console.WriteLine("grade: D\ncourse not passed");
            } 
            else if (gradenumber >= 0 && gradenumber < 60)
            {
                Console.WriteLine("grade: F\ncourse not passed");
            } else
            {
                Console.WriteLine("Invalid Grade");
            }

                //display if user passed or not


                Console.ReadKey();

        }
    }
}
