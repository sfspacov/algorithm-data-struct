using System;
using System.Collections.Generic;
using System.Linq;

namespace lonelyinteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(lonelyinteger(new List<int> { 1, 2, 3, 4, 3, 2, 1 }));
        }

        public static int lonelyinteger(List<int> a)
        {
            return a.GroupBy(x => x).First(y => y.Count() == 1).Key;
        }
    }
}
