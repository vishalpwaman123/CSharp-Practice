using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_Practice
{
    public class LinearQueue
    {
        private int[] _queue;
        private int front;
        private int rear;
        private int count;

        public LinearQueue(int capacity)
        {
            _queue = new int[capacity];
            front = rear = -1;
            count = 0;
        }

        public void Enqueue(int element)
        {
            if (count == _queue.Length)
                throw new Exception("Queue is full");

            if (front == -1)
                front = rear = 0;
            else
                rear += 1;


            _queue[rear] = element;
            count += 1;
        }

        public int Dequeue()
        {
            if (front == -1)
                throw new Exception("Queue is empty");

            int value = _queue[front++];
            count -= 1;

            if (count == 0)
                front = rear = -1;

            return value;
        }

        public bool Contains(int element)
        {
            if (front == -1)
                throw new Exception("Queue is empty");

            for (int i = 0; i < count; i++)
            {
                if (_queue[i] == element)
                    return true;
            }

            return false;
        }

        public int Count() => count;

        public int Peek()
        {
            if (front == -1)
                throw new Exception("Queue is empty");

            return _queue[front];
        }

        public void Clear()
        {
            front = rear = -1;
            count = 0;
        }

    }
}
