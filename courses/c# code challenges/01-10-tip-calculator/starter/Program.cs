using System;

namespace tipcalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the cost of your meal to calculate tip options:");
            var input = int.Parse(Console.ReadLine());

            // MARK: Result
            CalculateTip(input);
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static void CalculateTip(int cost)
        {

        }
    }
}
