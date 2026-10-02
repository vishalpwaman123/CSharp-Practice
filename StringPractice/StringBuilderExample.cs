using System;
using System.Collections.Generic;
using System.Text;

namespace StringPractice
{
    public class StringBuilderExample
    {

        public static void Run()
        {
            //Note:

            //string : string is immutable
            //string name = "vishal"; // is object 1
            //name = name + "waman"; // is object 2

            //StringBuilder : is mutable
            StringBuilder name = new StringBuilder("Vishal"); //create object 1
            Console.WriteLine(name.Insert(6, " Waman"));
            Console.WriteLine(name.Append("Kar")); //  modify object 1

            //StringBuilder Operation

            //Append()
            //AppendLine()
            //Insert()
            //Replace()
            //Remove()
            //Clear()
            //ToString()
            //Length
            //Capacity
        }
    }
}
