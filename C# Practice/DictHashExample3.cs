using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class DictHashExample3
    {
        public static void Run()
        {
            //Q4. Find duplicate numbers

            //DICTIONARY

            Dictionary<int, int> frequency = new Dictionary<int, int>();
            int[] numbers = { 1, 2, 3, 2, 4, 5, 1, 6 };

            foreach (int number in numbers)
            {
                if (frequency.ContainsKey(number))
                    frequency[number]++;
                else
                    frequency[number] = 1;
            }

            foreach (var item in frequency)
            {
                if (item.Value > 1)
                    Console.WriteLine(item.Key);
            }

            //HASH

            Console.WriteLine("-----------------------------------------------");

            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicate = new HashSet<int>();

            foreach(int number in numbers)
            {
                if (!seen.Add(number))
                    //duplicate.Add(number);
                    Console.WriteLine(number);
            }

        }
    }
}
