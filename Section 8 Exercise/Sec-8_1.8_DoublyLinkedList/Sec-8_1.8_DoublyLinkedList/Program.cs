using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_8_1._8_DoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            DoubleLinkedList linkedList = new DoubleLinkedList();

            // Insert data into the doubly linked list
            linkedList.Insert(100);
            linkedList.Insert(200);
            linkedList.Insert(300);
            linkedList.Insert(400);

            // Display the doubly linked list
            Console.WriteLine("Doubly Linked List:");
            linkedList.Display();

            Console.ReadKey();
        }
    }
}
