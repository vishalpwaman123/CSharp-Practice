using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class DictExample6
    {

        public static void Run()
        {
            //Q6. Count characters in a string

            var strings = "programming";
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (var s in strings)
            {
                if (frequency.ContainsKey(s))
                    frequency[s]++;
                else
                    frequency[s] = 1;
            }

            foreach(var item in frequency)
                Console.WriteLine($"{item.Key} : {item.Value}");

        }
    }
}