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

        public static string ReverseEachWord(string input)
        {
            string[] words = input.Split(' ');
            string result = string.Empty;
            foreach(string word in words)
            {
                for(int i=word.Length-1; i>=0; i--)
                    result += word[i];
                result += ' ';
            }

            return result.Trim();
        }

        public static bool IsAnagram(string input1, string input2)
        {
            if(input1.Length != input2.Length)
                return false;

            char[] c1 = input1.ToCharArray();
            Array.Sort(c1);
            char[] c2 = input2.ToCharArray();
            Array.Sort(c2);
            return new string(c1) == new string(c2);
        }
    }
}
