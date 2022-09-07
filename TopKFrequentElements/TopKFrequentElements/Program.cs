using System;
using System.Linq;

namespace TopKFrequentElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2);
        }

        public static int[] TopKFrequent(int[] nums, int k)
        {
            return nums
                .GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .Take(k)
                .Select(x => x.Key)
                .ToArray();
        }
    }
}
