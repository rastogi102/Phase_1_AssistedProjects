using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_8_1._12_Queues
{
    public class Queue
    {
        private List<int> queueList;

        public Queue()
        {
            queueList = new List<int>();
        }

        public bool IsEmpty()
        {
            return queueList.Count == 0;
        }

        public void Enqueue(int data)
        {
            queueList.Add(data);
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty. Cannot perform dequeue operation.");
            }

            int data = queueList[0];
            queueList.RemoveAt(0);
            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty. Cannot perform peek operation.");
            }

            return queueList[0];
        }
    }
}
