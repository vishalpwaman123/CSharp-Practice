using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class HashExample2
    {
        public static void Run()
        {
            //Find the missing number using HashSet.

            int[] arr = { 1, 2, 4, 5 };
            HashSet<int> seen = new HashSet<int>(arr);

            for (int i = 1; i <= arr.Length; i++)
                if (!seen.Contains(i))
                    Console.WriteLine(i);
        }
    }
}
