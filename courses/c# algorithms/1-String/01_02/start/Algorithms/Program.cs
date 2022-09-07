using System;

namespace Algorithms
{
    class Program
    {
        static string NormalizeString(string input){
            return input.ToLower().Trim().Replace(",","");
        }

        static void Main(string[] args)
        {
            Console.WriteLine(NormalizeString("Hello World, yeah       "));
        }
    }
}