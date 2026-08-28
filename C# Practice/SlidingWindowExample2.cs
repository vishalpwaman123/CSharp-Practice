using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class SlidingWindowExample2
    {
        public static void Run()
        {
            //Maximum Sum of 3 Consecutive Elements

            int[] arr = { 2, 1, 5, 1, 3, 2 };

            int windowSize = 3;
            int windowSum = 0;
            int maxSum = 0;
            int minIndex = 0;

            for (int i = 0; i < windowSize; i++)
                windowSum += arr[i];

            maxSum = windowSum;

            for (int i = windowSize; i < arr.Length; i++)
            {
                windowSum = windowSum - arr[i - windowSize] + arr[i];
                //maxSum = Math.Max(maxSum, windowSum);
                if( windowSum > maxSum)
                {
                    maxSum = windowSum;
                    minIndex = (i - windowSize + 1);
                }
            }

            for(int i=minIndex; i<minIndex+windowSize; i++)
                Console.Write(arr[i]);

            Console.WriteLine("\n"+maxSum);
        }
    }
}
