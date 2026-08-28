using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class SlidingWindowExample1
    {
        public static void Run()
        {

            //Find the longest substring without repeating characters.


            string str = "abcabcbb";

            //HashSet + Sliding Window

            HashSet<char> set = new HashSet<char>();

            int left = 0;
            int maxLength = 0;

            for (int right = 0; right < str.Length; right++)
            {
                while (set.Contains(str[right]))
                {
                    set.Remove(str[left]);
                    left++;
                }

                set.Add(str[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            Console.WriteLine(maxLength);


            //HashSet + Sliding Window

            Dictionary<char, int> lastSeen = new Dictionary<char, int>();

            int left1 = 0;
            int maxSize = 0;

            for (int right = 0; right < str.Length; right++)
            {
                if (lastSeen.TryGetValue(str[right], out int prev) && prev >= left1)
                {
                    left1 = prev + 1;
                }

                lastSeen[str[right]] = right;
                maxSize = Math.Max(maxSize, right - left1 + 1);
            }

            Console.WriteLine(maxSize);

        }
    }
}
