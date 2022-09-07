using System;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        static bool IsUppercase(string s){
            return s.All(char.IsUpper);
        }

        static bool IsLowercase(string s){
            return s.All(char.IsLower);
        }

        static bool IsPasswordComplex(string s){
            return s.Any(char.IsDigit) && s.Any(char.IsLower) && s.Any(char.IsUpper);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsLowercase("hello"));
            Console.WriteLine(IsUppercase("hello"));
            Console.WriteLine(IsLowercase("HELLO"));
            Console.WriteLine(IsUppercase("HELLO"));
            Console.WriteLine(IsPasswordComplex("Medellin2022!"));
        }

    }
}