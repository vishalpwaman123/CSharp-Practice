using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class SlidingWindowExample5
    {
        public static void Run()
        {
            //Count Even Numbers in Every Window
            int[] arr = { 2, 1, 4, 3, 6, 8, 5 };
            int windowSize = 3;

            int evenNoCount = 0;

            for (int i = 0; i < windowSize; i++)
            {
                if (arr[i] % 2 == 0)
                    evenNoCount++;
            }

            Console.WriteLine(evenNoCount);

            for (int i = windowSize; i < arr.Length; i++)
            {
                if (arr[i - windowSize] % 2 == 0)
                    evenNoCount--;

                if (arr[i] % 2 == 0)
                    evenNoCount++;

                Console.WriteLine(evenNoCount);
            }
        }
    }
}
