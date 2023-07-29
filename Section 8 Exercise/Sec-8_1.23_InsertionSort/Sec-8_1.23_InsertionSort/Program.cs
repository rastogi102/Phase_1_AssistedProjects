using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_8_1._23_InsertionSort
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
            new Student("Sam"),
            new Student("Aman"),
            new Student("Alisha"),
            new Student("Ram"),
            new Student("Chaman")
            };

            Console.WriteLine("Unsorted List of Students:");
            DisplayStudents(students);

            // Perform Insertion Sort
            InsertionSort(students);

            Console.WriteLine("\nSorted List of Students:");
            DisplayStudents(students);
            Console.ReadKey();
        }

        public static void InsertionSort(Student[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                Student current = arr[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(arr[j].Name, current.Name) > 0)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = current;
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
