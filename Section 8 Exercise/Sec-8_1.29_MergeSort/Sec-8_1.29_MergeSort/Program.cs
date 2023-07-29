using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_8_1._29_MergeSort
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

            // Perform Merge Sort
            MergeSort(marks);

            Console.WriteLine("\nSorted Marks in Ascending Order:");
            DisplayMarks(marks);
        }

        public static void MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return;
            }

            int mid = arr.Length / 2;
            int[] leftArray = new int[mid];
            int[] rightArray = new int[arr.Length - mid];

            Array.Copy(arr, 0, leftArray, 0, mid);
            Array.Copy(arr, mid, rightArray, 0, arr.Length - mid);

            MergeSort(leftArray);
            MergeSort(rightArray);
            Merge(arr, leftArray, rightArray);
        }

        public static void Merge(int[] arr, int[] leftArray, int[] rightArray)
        {
            int i = 0, j = 0, k = 0;

            while (i < leftArray.Length && j < rightArray.Length)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k++] = leftArray[i++];
                }
                else
                {
                    arr[k++] = rightArray[j++];
                }
            }

            while (i < leftArray.Length)
            {
                arr[k++] = leftArray[i++];
            }

            while (j < rightArray.Length)
            {
                arr[k++] = rightArray[j++];
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
