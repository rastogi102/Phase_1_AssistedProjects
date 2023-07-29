using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_8_1._12_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            Queue queue = new Queue();

            // Enqueue data into the queue
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            // Display the front element of the queue
            Console.WriteLine("Front element of the queue: " + queue.Peek());

            // Dequeue elements from the queue
            Console.WriteLine("Dequeued elements from the queue:");
            while (!queue.IsEmpty())
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.ReadKey();
        }
    }
}
