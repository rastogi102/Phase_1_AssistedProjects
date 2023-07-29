using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_6_1._6_ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp(); // Call the method to demonstrate various control flows
        }
        public static void doApp()
        {
            // Control flow examples
            int num = 10;

            // 1. If-else statement
            if (num > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            // 2. Switch statement
            switch (num)
            {
                case 0:
                    Console.WriteLine("The number is zero.");
                    break;
                case 10:
                    Console.WriteLine("The number is 10.");
                    break;
                default:
                    Console.WriteLine("The number is neither zero nor 10.");
                    break;
            }

            // 3. While loop
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("While loop iteration: " + count);
                count++;
            }

            // 4. Do-while loop
            count = 0;
            do
            {
                Console.WriteLine("Do-while loop iteration: " + count);
                count++;
            } while (count < 5);

            // 5. For loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("For loop iteration: " + i);
            }

            // 6. Nested loop
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("Nested loop iteration: (" + i + ", " + j + ")");
                }
            }

            // 7. Break and continue statements
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break; // Exit the loop when i equals 5
                }

                if (i % 2 == 0)
                {
                    continue; // Skip even numbers
                }

                Console.WriteLine("Loop iteration: " + i);
            }
        }

    }

}
