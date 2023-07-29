using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_6_1._4_PrimitiveTypesandExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp(); // Call the method to execute the expressions
        }
        public static void doApp() 
        { 
            // Declare variables of primitive types
            int[] intArray = new int[3] { 5, 12, 20 };
            double[] doubleArray = new double[2] { 3.14, 1.618 };
            bool[] boolArray = new bool[4] { true, false, false, true };
            char[] charArray = new char[5] { 'A', 'B', 'C', 'D', 'E' };

            // Execute expressions using the declared variables
            int result1 = intArray[0] + intArray[1];       // Adding two integers
            double result2 = doubleArray[0] * doubleArray[1]; // Multiplying two doubles
            bool result3 = boolArray[1] || boolArray[3];    // OR operation on two booleans
            char result4 = (char)(charArray[0] + 3);       // Incrementing char value by 3

            // Display the results
            Console.WriteLine("Result 1: " + result1);
            Console.WriteLine("Result 2: " + result2);
            Console.WriteLine("Result 3: " + result3);
            Console.WriteLine("Result 4: " + result4);

            Console.ReadKey();
        }

        
    }
 }

