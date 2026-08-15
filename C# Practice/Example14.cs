using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class Example14
    {

        public static void Run()
        {
            // Find the intersection of two arrays using Dictionary

            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 3, 4, 5, 6, 7 };

            Dictionary<int, bool> dict = new Dictionary<int, bool>();

            foreach (int number in arr1)
            {
                dict[number] = true;
            }

            foreach(int number in arr2)
            {
                if(dict.ContainsKey(number))
                    Console.WriteLine(number);
            }


            // HashSet

            HashSet<int> seen = new HashSet<int>(arr1);
            HashSet<int> unique = new HashSet<int>();

            foreach (int number in arr2)
                if (!seen.Add(number))
                    unique.Add(number);

            Console.WriteLine(string.Join(",", unique));

        }

    }
}
