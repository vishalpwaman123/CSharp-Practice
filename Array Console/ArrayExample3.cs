using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Console
{
    public class ArrayExample3
    {
        public int[] MoveZeroes(int[] arr)
        {
            int count = 0;
            foreach (int number in arr)
                if (number != 0)
                    arr[count++] = number;


            while (count < arr.Length)
                arr[count++] = 0;

            return arr;
        }
    }
}
