using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Console
{
    public class ArrayExample4
    {
        public int RemoveDuplicates(int[] arr)
        {
            int count = 0, first, second;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0)
                    if (arr[i - 1] == arr[i])
                    {
                        continue;
                    }
                    else
                    {
                        arr[count++] = arr[i];

                    }
                else
                    arr[count++] = arr[i];
            }

            return count;
        }
    }
}
