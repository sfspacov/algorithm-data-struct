using System;

namespace Algorithms
{
    class Program
    {

        static void ParseContents(string s)
        {
            Console.WriteLine("Option 1");

            foreach (char c in s)
            {
                Console.WriteLine(c);
            }

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                Console.WriteLine(c);
            }
        }

        static bool IsAtEvenIndex(string s, char item)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            var length = (s.Length / 2) + 1;

            for (int i = 0; i < length; i += 2)
            {
                if (s[i] == item)
                {
                    return true;
                }
            }

            return false;
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World".ToLower().Contains("ll"));
            //ParseContents("Hello World");
            string input = "HeLLo";
            Console.WriteLine(IsAtEvenIndex(input, 'l'));
            Console.WriteLine(IsAtEvenIndex(input, 'T'));
            Console.WriteLine(IsAtEvenIndex(input, 'H'));
            Console.WriteLine(IsAtEvenIndex("", 'H'));
            Console.WriteLine(IsAtEvenIndex(null, 'H'));
        }
    }
}