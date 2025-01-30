using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
     class GenericQueueHandler
    {
        private Queue queue = new Queue();

        public void Enqueue(object item)
        {
            queue.Enqueue(item);
        }

        public void PrintQueue()
        {
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
