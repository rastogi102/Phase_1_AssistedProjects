using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_8_1._25_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of students
            Student[] students = new Student[]
            {
            new Student("Tony"),
            new Student("Nikhil"),
            new Student("Aman"),
            new Student("Ram"),
            new Student("Neha")
            };

            Console.WriteLine("Students' Names using Recursion:");
            printViaRecursion(students, 0);
        }

        public static void printViaRecursion(Student[] arr, int index)
        {
            if (index < arr.Length)
            {
                Console.WriteLine(arr[index].Name);
                printViaRecursion(arr, index + 1);
            }

        }
    }
}
