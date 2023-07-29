using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_8_1._10_Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            Stack stack = new Stack();

            // Push data onto the stack
            stack.Push(1);
            Console.WriteLine("Top element of the stack: " + stack.Peek());

            stack.Push(2);
            Console.WriteLine("Top element of the stack: " + stack.Peek());

            stack.Push(3);
            Console.WriteLine("Top element of the stack: " + stack.Peek());

            stack.Push(4);
            Console.WriteLine("Top element of the stack: " + stack.Peek());

            // Display the elements of the stack
            Console.WriteLine("Elements Popped in the stack:");
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
            Console.ReadKey();
        }
    }
}
