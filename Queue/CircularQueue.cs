using System;
using System.Collections.Generic;
using System.Text;

namespace Queue_Practice
{
    public class CircularQueue
    {
        private int[] _queue;
        private int front, rear, size, count;

        public CircularQueue(int capacity)
        {
            _queue = new int[capacity];
            front = rear = -1;
            size = capacity;
            count = 0;
        }

        public void Enqueue(int element)
        {
            if (count == size)
                throw new Exception("Queue is full");

            if (front == -1)
                front = rear = 0;
            else
                rear = (rear + 1) % size;

            _queue[rear] = element;
            count++;
        }

        public int Dequeue()
        {
            if (front == -1)
                throw new Exception("Queue is empty");

            int value = _queue[front];

            if (count == 1)
                front = rear = -1;
            else
                front = (front + 1) % size;

            count--;
            return value;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < count; i++)
                if (_queue[i] == element)
                    return true;

            return false;
        }

        public int Peek()
        {
            if (front == -1)
                throw new Exception("Queue is empty.");

            return _queue[front];
        }

        public void Clear() { front = rear = -1; count = 0; }

        public int Count() => count;

    }
}
