using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_8_1._31_QuickSort
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

            // Perform Quick Sort
            QuickSort(marks, 0, marks.Length - 1);

            Console.WriteLine("\nSorted Marks in Ascending Order:");
            DisplayMarks(marks);
            Console.ReadKey();
        }


        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i + 1;
        }

        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
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
