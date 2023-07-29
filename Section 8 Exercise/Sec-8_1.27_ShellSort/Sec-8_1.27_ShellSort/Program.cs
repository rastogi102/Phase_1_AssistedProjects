using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_8_1._27_ShellSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            // Create an array of marks of subjects
            int[] marks = { 85, 65, 92, 78, 88, 70, 95, 60 };

            Console.WriteLine("Unsorted Marks:");
            DisplayMarks(marks);

            // Perform Shell Sort
            ShellSort(marks);

            Console.WriteLine("\nSorted Marks in Ascending Order:");
            DisplayMarks(marks);
            Console.ReadKey();
        }

        public static void ShellSort(int[] arr)
        {
            int n = arr.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j = i;

                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }

                    arr[j] = temp;
                }

                gap /= 2;
            }
        }

        public static void DisplayMarks(int[] arr)
        {
            foreach (var mark in arr)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
    }
}
