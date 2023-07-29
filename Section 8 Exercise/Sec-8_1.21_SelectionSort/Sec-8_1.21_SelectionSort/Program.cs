using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_8_1._21_SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            // Create an array of students with Indian names
            Student[] students = new Student[]
            {
            new Student("Aarav"),
            new Student("Deepanshu"),
            new Student("Manisha"),
            new Student("Ananya"),
            new Student("Gori"),
            new Student("Chetan"),
            new Student("Teena"),
            new Student("Dhruv"),
            new Student("Esha"),
            new Student("Suraj"),
            };

            Console.WriteLine("Unsorted List of Students:");
            DisplayStudents(students);

            // Perform Selection Sort
            SelectionSort(students);

            Console.WriteLine("\nSorted List of Students:");
            DisplayStudents(students);
            Console.ReadKey();
        }

        public static void SelectionSort(Student[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(arr[j].Name, arr[minIndex].Name) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    // Swap the elements
                    Student temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
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
