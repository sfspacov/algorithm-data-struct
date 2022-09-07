using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_Max_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            miniMaxSum(new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 });
        }
        public static void miniMaxSum(List<int> arr)
        {
            Int64 min = 0;
            foreach (Int64 x in arr.OrderBy(x => x).Take(4))
                min += x;
            Int64 max = 0;
            foreach (Int64 x in arr.OrderByDescending(x => x).Take(4))
                max+=x;

            Console.Write($"{min} {max}");
        }
    }
}