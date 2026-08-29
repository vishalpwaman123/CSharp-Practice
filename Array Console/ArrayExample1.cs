using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Console
{
    public class ArrayExample1
    {
        public int FindMaximum(int[] arr)
        {
            int maxNumber = int.MinValue;

            foreach (int number in arr)
                if (number > maxNumber)
                    maxNumber = number;

            return maxNumber;
        }
    }
}
