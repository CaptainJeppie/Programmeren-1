using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter course name: ");
            string coursename = Console.ReadLine();

            Console.Write("Enter number of students: ");
            int numberofstudents = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            string[] students = new string[numberofstudents];
            int[] grades = new int[numberofstudents];
            for (int i = 0; i < numberofstudents; i++)
            {
                Console.Write($"Enter name of student {i}: ");
                students[i] = Console.ReadLine();
            }
            Console.WriteLine("\n");
            int totalgrades = 0;
            for (int i = 0; i < numberofstudents; i++)
            {
                Console.Write($"Enter grade of {students[i]}: ");
                grades[i] = int.Parse(Console.ReadLine());
                totalgrades += grades[i];
            }
            int highestgrade = 0;
            double averagegrade = (double)totalgrades / (double)numberofstudents;
            string studenthighestgrade = "";
            for (int i = 0; i < numberofstudents; i++)
            {
                if (highestgrade <= grades[i])
                {
                    highestgrade = grades[i];
                    studenthighestgrade = students[i];
                }
            }
            Console.WriteLine($"\nAverage grade: {averagegrade:0.00}\nStudent {studenthighestgrade} has maximum grade: {highestgrade}\n");
            for (int i = 0; i < numberofstudents; i++)
            {
                Console.WriteLine($"Grade for student {students[i]} (course {coursename}): {grades[i]}");
            }

            Console.ReadKey();
        }
    }
}
