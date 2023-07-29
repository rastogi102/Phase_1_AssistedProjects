using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_8_1._19_BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            // Create an array of students
            Student[] students = new Student[]
            {
            new Student("Nikhil"),
            new Student("Alisha"),
            new Student("Chaman"),
            new Student("Ram"),
            new Student("Sunita")
            };

            Console.WriteLine("Unsorted List of Students:");
            DisplayStudents(students);

            // Perform Bubble Sort
            BubbleSort(students);

            Console.WriteLine("\nSorted List of Students:");
            DisplayStudents(students);
            Console.ReadKey();
        }

        public static void BubbleSort(Student[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (string.Compare(arr[j].Name, arr[j + 1].Name) > 0)
                    {
                        // Swap the elements
                        Student temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void DisplayStudents(Student[] arr)
        {
            foreach (var student in arr)
            {
                Console.WriteLine(student.Name);
            }
        }
    } 

}

