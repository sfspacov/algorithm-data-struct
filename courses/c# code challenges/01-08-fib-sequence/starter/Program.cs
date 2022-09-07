using System;
using System.Collections.Generic;

namespace fibsequence
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the number of Fibonacci elements you'd like to calculate:");
            int input = int.Parse(Console.ReadLine());

            // MARK: Result
            var sequence = CalculateFibonacci(input);
            foreach (var fibonacci in sequence)
            {
                Console.WriteLine(fibonacci);
            }

            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static List<int> CalculateFibonacci(int length)
        {
            List<int> sequence = new List<int>();

            return sequence;
        }
    }
}