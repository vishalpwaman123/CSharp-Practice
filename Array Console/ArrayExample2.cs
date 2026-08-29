using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Console
{
    public class ArrayExample2
    {
        public int FindSecondMaximum(int[] arr)
        {
            int max = int.MinValue;
            int secondMax = max-1;

            foreach(int number in arr)
                if(number > max)
                {
                    secondMax = max;
                    max = number;
                }else if(max != number && number > secondMax)
                {
                    secondMax = number;
                }

            return secondMax;
        }
    }
}
