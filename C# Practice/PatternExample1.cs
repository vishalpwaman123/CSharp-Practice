using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class PatternExample1
    {
        public static void Run()
        {

            //    *
            //   ***
            //  *****
            // *******
            //*********
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
                Console.WriteLine(
                    new string(' ', (n-i)) +
                    new string('*', 2*i-1)
                    );
        }
    }
}
