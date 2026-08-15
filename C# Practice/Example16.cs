using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class Example16
    {
        public static void Run()
        {
            //Remove duplicates from an array

            int[] arr1 = { 1, 2, 2, 3, 4, 4, 5, 1 };

            // DICTIONARY

            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            List<int> newArray = new List<int>();

            foreach (int number in arr1)
            {
                if (!dict.ContainsKey(number))
                {
                    dict[number] = true;
                    newArray.Add(number);
                }
            }

            Console.WriteLine(string.Join(",", newArray.ToArray()));

            // HASHSET

            HashSet<int> seen = new HashSet<int>();

            foreach(int number in arr1)
            {
                seen.Add(number);
            }

            Console.WriteLine(string.Join(",", seen.ToArray()));
        }
    }
}
