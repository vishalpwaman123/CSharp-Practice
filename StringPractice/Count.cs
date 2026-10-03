using System;
using System.Collections.Generic;
using System.Text;

namespace StringPractice
{
    public class Count
    {
        public static int CountVowel(string input)
        {
            char[] vowels = { 'a', 'e', 'o', 'u', 'i' };
            int count = 0;
            foreach (char c in input)
                if (vowels.Contains(char.ToLower(c)))
                    count += 1;

            return count;
        }

        public static int CountCharacter(string input, char target)
        {
            int count = 0;
            foreach (char c in input)
                if (char.ToLower(c) == char.ToLower(target))
                    count += 1;

            return count;
        }

        public static string RemoveDuplicate(string input)
        {
            string unique = string.Empty;
            foreach (char c in input)
            {
                if (unique.Contains(c))
                    continue;
                unique += c;
            }

            return unique;
        }
    }
}
