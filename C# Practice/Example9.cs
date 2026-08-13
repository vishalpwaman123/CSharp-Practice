using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class Example9
    {
        public static void Run()
        {

            // Check whether two strings are anagrams

            string str1 = "listen";
            string str2 = "silent";

            // DICTIONARY

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            if (str1.Length != str2.Length)
                Console.WriteLine("both string not anagrams");

            // Count characters from first string
            foreach (char c in str1)
                if (frequency.ContainsKey(c))
                    frequency[c]++;
                else
                    frequency[c] = 1;

            // Remove characters using second string
            foreach (char c in str2)
            {
                if (!frequency.ContainsKey(c))
                {
                    Console.WriteLine("both string not anagrams");
                    return;
                }

                frequency[c]--;

                if (frequency[c] == 0)
                    frequency.Remove(c);
            }

            Console.WriteLine($"Is both string is anagrams : {frequency.Count == 0}");


            Console.WriteLine("----------------------------------------------------------");

            //HASH



        }
    }
}
