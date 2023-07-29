using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_6_1._13_WorkinWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }
        public static void doApp()
        {
            string filePath = "sample.txt";

            // Writing data to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("This is the first line of the text file.");
                writer.WriteLine("This is the second line.");
                writer.WriteLine("And this is the third line.");
            }

            Console.WriteLine("Text file created and data written successfully.");

            // Reading data from the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                Console.WriteLine("Reading data from the text file:");

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
 }

