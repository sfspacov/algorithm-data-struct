using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {

        static void Main(string[] args)
        {
            Array.ForEach(
                FindItemsJustOnFirstArray(new int[] { 3, 2, 8, 51,78 ,38,489,48,1,0,5 }, new int[] { 51, 7, 8, 3, 2 })
            , (x) => { Console.Write($"{x} "); });
        }

        static int[] FindItemsJustOnFirstArray(int[] a, int[] b)
        {
            var hash = new HashSet<int>();
            var result = new List<int>();

            foreach (var item in b)
                hash.Add(item);

            foreach (var item in a)
            {
                if (!hash.Contains(item))
                    result.Add(item);
            }

            return result.ToArray();
        }
    }
}