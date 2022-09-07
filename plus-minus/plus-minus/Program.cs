using System;
using System.Collections.Generic;
using System.Linq;

namespace plus_minus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            plusMinus(new List<int> { -4,3,-9,0,4,1 });
        }
        public static void plusMinus(List<int> arr)
        {
            decimal negative = arr.Count(x => x < 0);
            decimal positive = arr.Count(x => x > 0);
            decimal zero = arr.Count(x => x == 0);

            Console.WriteLine($"{positive / arr.Count:N6}");
            Console.WriteLine($"{negative / arr.Count:N6}");
            Console.WriteLine($"{zero / arr.Count:N6}");
        }
    }
}
