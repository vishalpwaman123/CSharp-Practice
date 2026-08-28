

using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class DictExample5
    {
        public static void Run()
        {
            //Q5. Find the number with maximum frequency
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            int[] numbers = { 1, 2, 2, 3, 3, 3, 4 };

            foreach (int number in numbers)
            {
                if (frequency.ContainsKey(number))
                    frequency[number]++;
                else
                    frequency[number] = 1;
            }

            KeyValuePair<int, int> Max = new();
            foreach (var item in frequency)
            {
                if(item.Value > Max.Value)
                    Max = item;
            }

            Console.WriteLine($"{Max.Key} : {Max.Value}");
        }
    }
}
