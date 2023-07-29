using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_8_1._7_SinglyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            SingleLinkedList linkedList = new SingleLinkedList();

            // Insert data into the linked list
            linkedList.Insert(10);
            linkedList.Insert(20);
            linkedList.Insert(30);
            linkedList.Insert(40);

            // Display the linked list
            Console.WriteLine("Linked List:");
            linkedList.Display();

            Console.ReadKey();
        }
    }
}
