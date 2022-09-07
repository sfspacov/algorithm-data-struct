using System;
using System.Text;

namespace Algorithms
{
    class Program
    {

        static string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var reversed = new StringBuilder(input.Length);
            for (int i = input.Length - 1; i >= 0; i--)
                reversed.Append(input[i]);

            return reversed.ToString();
        }

        static string Reverse2(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main(string[] args)
        {
            var challenge = new Challenge();
            var input ="Vejo a fumaça subir, vou na moral, tem que bortar na fé na Humilde!";
            Console.WriteLine(
                challenge.Reverse(
                    challenge.Normalize(input)));
        }
    }
}