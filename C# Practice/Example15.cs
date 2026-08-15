using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class Example15
    {
        public static void Run()
        {
            // Find whether two arrays contain the same frequency of elements.

            int[] arr1 = { 1, 2, 2, 3, 3, 3 };
            int[] arr2 = { 3, 2, 3, 1, 3, 2 };

            //Dictionary<int, int> dict1 = new Dictionary<int, int>();
            //Dictionary<int, int> dict2 = new Dictionary<int, int>();

            //if (arr1.Length != arr2.Length)
            //{
            //    Console.WriteLine("Two array not same frequency");
            //    return;
            //}

            //foreach (int number in arr1)
            //{
            //    if (dict1.ContainsKey(number))
            //        dict1[number]++;
            //    else
            //        dict1[number] = 1;
            //}

            //foreach (int number in arr2)
            //{
            //    if (dict2.ContainsKey(number))
            //        dict2[number]++;
            //    else
            //        dict2[number] = 1;
            //}

            //foreach (KeyValuePair<int, int> item in dict1)
            //{
            //    if (!dict2.ContainsKey(item.Key))
            //    {
            //        Console.WriteLine("Two array not same frequency");
            //        return;
            //    }
            //    else
            //        if (item.Value != dict2[item.Key])
            //        {
            //            Console.WriteLine("Two array not same frequency");
            //            return;
            //        }

            //}

            //Console.WriteLine("Two array has same frequency");

            //Console.WriteLine("\n\n\n-----------------------------------------------------------------------------\n\n\n");

            Dictionary<int, int> dict3 = new Dictionary<int, int>();

            foreach (int number in arr1)
            {
                if (dict3.ContainsKey(number))
                    dict3[number]++;
                else
                    dict3[number] = 1;
            }

            foreach (int number in arr2)
            {
                if (!dict3.ContainsKey(number))
                {
                    Console.WriteLine("Two array has not same frequency");
                    return;
                }

                dict3[number]--;
                if (dict3[number] == 0)
                    dict3.Remove(number);
            }

            if (dict3.Count == 0)
                Console.WriteLine("two array has same frequency");

        }
    }
}
