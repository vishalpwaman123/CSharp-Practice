using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class Example12
    {
        public static void Run()
        {
            int[] numbers = { 1, 1, 1, 2, 2, 3 };
            int k = 2;

            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach(int i in numbers)
            {
                if (frequency.ContainsKey(i))
                    frequency[i]++;
                else
                    frequency[i] = 1;
            }

            var result = frequency.OrderByDescending(x=>x.Value).Take(k).ToList();

            foreach(var i in result)
                Console.WriteLine(i.Key);
        }
    }
}
