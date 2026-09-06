using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_Practice
{
    public class QueueBasic
    {
        public static void Run()
        {
            Queue<int> _queue = new();

            //INSERT
            _queue.Enqueue(1);
            _queue.Enqueue(2);
            _queue.Enqueue(3);
            _queue.Enqueue(4);
            _queue.Enqueue(5);

            foreach (int element in _queue)
                Console.Write("[" + element + "]");

            Console.WriteLine("\nDequeue : " + _queue.Dequeue());
            Console.WriteLine("Peek : " + _queue.Peek());
            Console.WriteLine("Count : " + _queue.Count);
            _queue.Clear();
            Console.WriteLine("Count After Clear : " + _queue.Count);
        }
    }
}
