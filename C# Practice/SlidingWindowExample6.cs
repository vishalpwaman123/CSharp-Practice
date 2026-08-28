using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class SlidingWindowExample6
    {
        public static void Run()
        {
            //Problem 5: Smallest Subarray With Sum ≥ K
            //Given an array of positive integers and a number k, find the minimum length subarray whose sum is greater than or equal to k.

            // Example

            // Input

            // [2, 1, 5, 2, 3, 2]
            // k = 7

            // Expected output :

            // Minimum Length = 2
            // Subarray = [5, 2]

            int[] arr = { 2, 1, 5, 2, 3, 2 };
            int k = 7;

            int windowSum = 0;
            int minWindowSize = int.MaxValue;
            int left = 0;
            int maxIndex = 0, minIndex=0;

            for (int right = 0; right < arr.Length; right++)
            {
                windowSum += arr[right];

                while (windowSum >= k)
                {
                    int currentWindow = right - left + 1;

                    if (minWindowSize > currentWindow)
                    {
                        minWindowSize = currentWindow;
                        maxIndex = right;
                        minIndex = left;
                    }

                    windowSum -= arr[left];
                    left++;
                }
            }

            Console.WriteLine(minWindowSize);
            for (int i = minIndex; i <= maxIndex; i++)
                Console.Write(arr[i]+" ");
        }
    }
}
