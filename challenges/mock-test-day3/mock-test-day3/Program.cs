using System;
using System.Linq;

namespace mock_test_day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(palindromeIndex("bsyhvwfuesumsehmytqioswvpcbxyolapfywdxeacyuruybhbwxjmrrmjxwbhbyuruycaexdwyfpaloyxbcpwsoiqtymhesmuseufwvhysb"));
        }

        public static int palindromeIndex(String s)
        {
            int start = 0;
            int end = s.Length - 1;
            while (start < end && s[start] == s[end])
            {
                start++;
                end--;
            }
            if (start >= end) return -1; // already a palindrome
                                         // We need to delete here
            if (isPalindrome(s, start + 1, end)) return start;
            if (isPalindrome(s, start, end - 1)) return end;
            return -1;
        }

        public static bool isPalindrome(String s, int start, int end)
        {
            while (start < end && s[start] == s[end])
            {
                start++;
                end--;
            }
            return start >= end;
        }


        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static int palindromeIndex2(string s)
        {
            if (Reverse(s) == s)
                return -1;

            for (int i = 0; i < (s.Length / 2); i++)
            {
                var first = s[i];
                var inverseIndex = s.Length - 1 - i;
                var last = s[inverseIndex];

                if (first != last)
                {
                    var next = s[i + 1];
                    var result = next == first ? inverseIndex : i;
                    return result;
                }
            }
            return -1;
        }
    }
}