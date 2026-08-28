using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Practice
{
    public class DictHashExample2
    {
        public static void Run()
        {
            //Q3.Find the first duplicate number

            //DICTIONARY

            Dictionary<int, int> frequency = new Dictionary<int, int>();
            int[] numbers = { 10, 20, 30, 20, 40, 30 };

            foreach (int number in numbers)
            {
                if (frequency.ContainsKey(number))
                {
                    Console.WriteLine("Dictionart : First Duplicate number : " + number);
                    break;
                }
                else
                    frequency[number] = 1;
            }

            // HASHSET

            Console.WriteLine("------------------------------------------------------");

            HashSet<int> seen = new HashSet<int>();

            foreach (int number in numbers)
            {
                if (!seen.Add(number))
                {
                    Console.WriteLine("HashSet : First Duplicate number : " + number);
                    break;
                }
            }

        }
    }
}
