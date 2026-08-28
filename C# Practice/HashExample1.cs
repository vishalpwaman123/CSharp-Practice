using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class HashExample1
    {
        public static void Run()
        {
            //Find union of two arrays.

            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 3, 4, 5, 6, 7 };

            HashSet<int> union = new HashSet<int>(arr1);

            foreach(int number in arr2)
            {
                union.Add(number);
            }

            Console.WriteLine(string.Join(",", union));
        }
    }
}
