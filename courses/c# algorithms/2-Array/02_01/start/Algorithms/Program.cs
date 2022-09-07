using System;
using System.Linq;

namespace Algorithms
{
    class Program
    {

        static Boolean LinearSearch(int[] input, int n)
        {
            foreach (var item in input)
            {
                if (n == item)
                    return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(LinearSearch(arr, 4));
            Console.WriteLine(LinearSearch(arr, 8));

            var item = Array.Find(arr, x => x == 3);
            var items = Array.FindAll(arr, x => x >= 5);
            Console.WriteLine(item);
            Console.WriteLine(arr.Any(x => x == 3));
            Array.ForEach(items, x=> Console.WriteLine(x));
        }
    }
}