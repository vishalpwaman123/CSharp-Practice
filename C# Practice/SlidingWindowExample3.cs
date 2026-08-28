namespace C__Practice
{
    public class SlidingWindowExample3
    {
        public static void Run()
        {
            //Minimum Sum of K Consecutive Elements
            int[] arr = { 4, 2, 1, 7, 8, 1, 2 };

            int windowSize = 3;
            int minSum = 0;
            int windowSum = 0;
            int minIndex = 0;

            for (int i = 0; i < windowSize; i++)
                windowSum += arr[i];

            minSum = windowSum;

            for (int i = windowSize; i < arr.Length; i++)
            {
                windowSum = windowSum - arr[i - windowSize] + arr[i];
                if (windowSum < minSum)
                {
                    minSum = windowSum;
                    minIndex = i - windowSize + 1;
                }
            }

            Console.WriteLine(minSum);

            for (int i = minIndex; i < minIndex + windowSize; i++)
                Console.Write(arr[i]+" ");
        }
    }
}
