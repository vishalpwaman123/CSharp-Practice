using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Project
{
    public class StackExample2
    {
        public static string Reverse(string input)
        {

            Stack<char> _stack = new();

            string reverse = string.Empty;

            foreach (char character in input)
                _stack.Push(character);

            foreach (char item in _stack)
                reverse += item;

            return reverse;
        }
    }
}
