using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Console
{
    public class ArrayExample4
    {
        public int[] MoveZeroesToEnd(int[] arr)
        {
            int insertAt = 0;

            foreach (int number in arr)
                if (number != 0)
                    arr[insertAt++] = number;

            while (insertAt < arr.Length)
                arr[insertAt++] = 0;

            return arr;
        }
    }
}
