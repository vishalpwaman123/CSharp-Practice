using System;
using System.Collections.Generic;
using System.Text;

namespace StringPractice
{
    public class Palindrome
    {
        public static bool Run(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException("Invalid Input");

            string reverse = string.Empty;
            // Reverse string
            for (int i = input.Length - 1; i >= 0; i--)
                reverse += input[i];

            return input == reverse;
        }
    }
}
