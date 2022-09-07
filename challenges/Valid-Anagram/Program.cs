using System;
using System.Collections.Generic;
using System.Linq;

namespace Valid_Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
            IsAnagram("az", "za"));
        }

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            var dicS = new int[26];
            var dicT = new int[26];
            var aPosition = 97;

            for (int i = 0; i < s.Length; i++)
            {
                var indexS = (int)(s[i]) - aPosition;
                dicS[indexS]++;

                var indexT = (int)(t[i]) - aPosition;
                dicT[indexT]++;
            }
            return dicS.SequenceEqual(dicT);
        }
    }
}
