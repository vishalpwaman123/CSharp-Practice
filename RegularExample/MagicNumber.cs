using System;
using System.Collections.Generic;
using System.Text;

namespace RegularExample
{
    public class MagicNumber
    {
        public static int Run(int input)
        { 
            while(input > 10)
            {
                int temp = input;
                int sum = 0;
                while (temp > 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }
                input = sum;
            }

            return input;
        }
    }
}
