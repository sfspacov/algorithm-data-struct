using System;

namespace Algorithms
{
    class Program
    {
        static void Reverse(int[] input)
        {

            for (int i = input.Length / 2 - 1; i >= 0; i--)
            {
                var aux = input[i];
                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 - i] = aux;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Reverse(arr);
            Array.ForEach(arr, Console.WriteLine);
            Reverse(arr);
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}