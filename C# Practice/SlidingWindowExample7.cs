using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class SlidingWindowExample7
    {
        public static void Run()
        {
            //Longest Subarray With Sum ≤ K

            int[] arr = { 2, 1, 5, 1, 3, 2 };
            int k = 7;
            int windowSum = 0, left = 0, maxWindow = 0;

            for (int right = 0; right < arr.Length; right++)
            {
                windowSum += arr[right];

                while (windowSum > k)
                    windowSum -= arr[left++];

                maxWindow = Math.Max(maxWindow, right - left + 1);

            }

            Console.WriteLine(maxWindow);
        }
    }
}
