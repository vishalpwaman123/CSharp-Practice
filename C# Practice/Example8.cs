using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class Example8
    {
        public static void Run()
        {
            //Q8. Find duplicate characters

            //DICTIONARY

            Dictionary<char, int> frequency = new Dictionary<char, int>();
            string sentence = "programming";

            foreach (char c in sentence)
                if (frequency.ContainsKey(c))
                    frequency[c]++;
                else
                    frequency[c] = 1;


            foreach (KeyValuePair<char, int> item in frequency)
                if (item.Value > 1)
                    Console.WriteLine($"{item.Key}");


            Console.WriteLine("------------------------------------------");

            //HASH

            HashSet<char> seen = new HashSet<char>();
            HashSet<char> duplicate = new HashSet<char>();

            foreach (char c in sentence)
                if (!seen.Add(c))
                    duplicate.Add(c);


            foreach (char c in duplicate)
                Console.WriteLine(c);
                    
        }
    }
}
