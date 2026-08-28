using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class SlidingWindowExample4
    {
        public static void Run()
        {
            //Find Average of Every K Consecutive Elements
            int[] arr = { 1, 3, 2, 6, -1, 4, 1, 8, 2 };
            int windowSize = 5;
            double windowSum = 0;

            for (int i = 0; i < windowSize; i++)
            {
                windowSum += arr[i];
            }

            Console.WriteLine(windowSum / windowSize);

            for (int i = windowSize; i < arr.Length; i++)
            {
                windowSum = windowSum - arr[i - windowSize] + arr[i];
                Console.WriteLine(windowSum / windowSize);
            }
        }
    }
}
