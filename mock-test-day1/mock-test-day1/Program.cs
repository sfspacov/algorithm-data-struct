using System;
using System.Collections.Generic;

namespace mock_test_day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int findMedian(List<int> arr)
        {
            arr.Sort();
            int index = arr.Count/2;
            return arr[index];
        }
    }
}
