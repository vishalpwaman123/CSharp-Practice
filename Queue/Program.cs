using Queue_Practice;
using System.Collections;

//QueueBasic.Run();

//Problem 1 — Implement Circular Queue Using Array

//CircularQueue _queue = new(5);
LinearQueue _queue = new(5);
_queue.Enqueue(10);
_queue.Enqueue(20);
_queue.Enqueue(30);
_queue.Enqueue(40);
_queue.Enqueue(50);

Console.WriteLine("Contains 20 : " + _queue.Contains(20));
Console.WriteLine("Contains 60 : " + _queue.Contains(60));
Console.WriteLine("Count : " + _queue.Count());
Console.WriteLine("Peek : " + _queue.Peek());
Console.WriteLine("Dequeue : " + _queue.Dequeue());
Console.WriteLine("Count : " + _queue.Count());
_queue.Clear();
Console.WriteLine("After Clear Count : " + _queue.Count());