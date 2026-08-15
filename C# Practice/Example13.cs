using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice
{
    public class Example13
    {
        public static void Run()
        {

            //    *
            //   ***
            //  *****
            // *******
            //*********

        string str = "";

            for (int i = 1; i <= 5; i++)
                Console.WriteLine(
                    new string(' ', 4-(i-1)) +
                    new string('*', 2*i-1)
                    );
        }
    }
}
