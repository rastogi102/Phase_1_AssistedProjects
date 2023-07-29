using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_8_1._4_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            // Arrays to store student names and marks
            string[] students = new string[5];
            int[] marks = new int[5];

            // Input student names and marks
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter student name: ");
                students[i] = Console.ReadLine();

                Console.Write("Enter marks for " + students[i] + ": ");
                int.TryParse(Console.ReadLine(), out marks[i]);
            }

            // Display the list of students and their marks
            Console.WriteLine("\nList of Students and Their Marks:");
            Console.WriteLine("-------------------------");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(students[i] + " : " + marks[i]);
            }

            // Calculate and display the average marks
            double averageMarks = (double)marks.Sum() / marks.Length;
            Console.WriteLine("\nAverage Marks: " + averageMarks);
            Console.ReadKey();
        }

    }
}

