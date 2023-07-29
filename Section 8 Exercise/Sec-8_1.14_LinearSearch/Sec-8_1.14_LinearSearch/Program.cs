using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_8_1._14_LinearSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            // Input array size from the user
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            // Create an array of integers
            int[] array = new int[size];

            // Input array elements from the user
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            // Input value to search for from the user
            Console.Write("Enter the value to search for: ");
            int searchValue = int.Parse(Console.ReadLine());

            // Perform Linear Search
            int index = LinearSearch(array, searchValue);

            // Display the result
            if (index != -1)
            {
                Console.WriteLine($"The value {searchValue} is found at index {index}.");
            }
            else
            {
                Console.WriteLine($"The value {searchValue} is not found in the array.");
            }
            Console.ReadKey();
        }

        public static int LinearSearch(int[] array, int searchValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchValue)
                {
                    return i;
                }
            }
            return -1; // Value not found in the array
            
        }

    }
}
   

