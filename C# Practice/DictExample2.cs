using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Practice
{
    public class DictExample2
    {
        public static void Run()
        {

            // Q10. Two Sum

            int[] numbers = { 2, 7, 11, 15, 5, 4 };
            int target = 9;

            Dictionary<int, int> dictNumber = new Dictionary<int, int>();

            for(int i = 0; i < numbers.Length; i++)
            {
                int second = target - numbers[i];
                if (dictNumber.ContainsKey(second))
                {
                    Console.WriteLine($"{numbers[i]} + {second} = {target}");
                }

                dictNumber[numbers[i]] = i;
            }

        }

    }
}
