using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_6_1._8_WorkingWithText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }
        public static void doApp()
        {
            // Using string
            string name = "John";
            string message = "Hello, " + name + "!"; // Concatenating strings

            // Using StringBuilder
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("This is a ");
            stringBuilder.Append("StringBuilder ");
            stringBuilder.Append("example.");
            string result = stringBuilder.ToString();

            // Displaying the results
            Console.WriteLine(message);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
