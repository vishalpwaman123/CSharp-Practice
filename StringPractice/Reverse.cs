using System;
using System.Collections.Generic;
using System.Text;

namespace StringPractice
{
    public class Reverse
    {
        public static string ReverseCharacter(string input)
        {
            // Input : Vishal
            // Output : lahsiV

            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException("Invalid Input");

            string reverse = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
                reverse += input[i];

            return reverse;
        }

        public static string ReverseWord(string input)
        {
            // Input : Vishal Prabhakar Waman
            string[] word = input.Split(" ");
            string reverse = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
                reverse += word[i] + ' ';

            return reverse;
        }
    }
}
