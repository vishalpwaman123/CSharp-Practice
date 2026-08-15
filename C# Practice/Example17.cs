using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class Example17
    {
        public static void Run()
        {
            // Find unique elements in an array.

            int[] arr = { 1, 2, 2, 3, 4, 4, 5 };

            // DICTIONARY

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int number in arr)
            {
                if (dict.ContainsKey(number))
                    dict[number]++;
                else
                    dict[number] = 1;
            }

            var unique = dict.Where(z => z.Value == 1).Select(x => x.Key).ToArray();

            Console.WriteLine(string.Join(",", unique));

            // HASHSET

            HashSet<int> seen = new HashSet<int>();
            HashSet<int> _unique = new HashSet<int>();

            foreach (int number in arr)
            {
                if (seen.Add(number))
                    _unique.Add(number);
                else
                    _unique.Remove(number);

            }

            Console.WriteLine(string.Join(",", _unique));
        }
    }
}
