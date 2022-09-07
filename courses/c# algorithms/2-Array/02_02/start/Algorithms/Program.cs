using System;

namespace Algorithms
{
    class Program
    {

        static bool BinarySearch(int[] inputArray, int item)
        {
            var min = 0;
            var max = inputArray.Length - 1;
            var mid = max - min;
            while (min <= max)
            {
                mid = (max + min) / 2;
                
                if (item == inputArray[mid])
                    return true;

                if (item > inputArray[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
            }

            return false;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(BinarySearch(arr, 4));
            Console.WriteLine(BinarySearch(arr, 41));
            Console.WriteLine(BinarySearch(arr, 5));
            //Console.WriteLine(Array.BinarySearch(arr, -59));
        }
    }
}