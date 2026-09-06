using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Project
{
    public class StackBasic
    {
        public static void Run()
        {

            // Declare Stack
            Stack<int> stack = new Stack<int>();

            // Insert Into Stack

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            // Read all Element

            foreach (int number in stack)
                Console.WriteLine(number);

            // Read Top Element Without  Remove

            Console.WriteLine($"Stack Last Element : {stack.Peek()}");

            // Check Element Exist In Stack

            Console.Write("Enter Stack Value : ");
            int value = int.Parse(Console.ReadLine());

            if (stack.Contains(value))
                Console.WriteLine("Value Exist In Stack");
            else
                Console.WriteLine("Value Not Exist In Stack");

            // Remove Top Value

            Console.WriteLine($"Remove Stack Top Element : {stack.Pop()}");

            // Count How Many Element Into Stack

            Console.WriteLine($"Total Element Into Stack : {stack.Count}");

            // Clear Stack

            stack.Clear();

            Console.WriteLine($"Total Element After Clear Into Stack : {stack.Count}");

        }
    }
}
