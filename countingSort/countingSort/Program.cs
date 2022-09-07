using System;
using System.Collections.Generic;
using System.Linq;

namespace countingSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            countingSort(new List<int> { 1, 1, 3, 2, 1 });
        }
        public static List<int> countingSort(List<int> arr)
        {
            var result = new int[arr.Count];

            for (int i = 0; i < arr.Count; i++)
            {
                result[arr[i]] += 1;
            }

            return result.ToList();
        }
    }
}
