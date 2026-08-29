using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Console
{
    public class ArrayExample3
    {
        public int[] ReverseArray(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                (arr[left], arr[right]) = (arr[right], arr[left]);
                left++;
                right--;
            }

            return arr;
        }
    }
}
