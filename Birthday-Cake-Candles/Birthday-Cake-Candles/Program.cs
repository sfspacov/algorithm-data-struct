using System;
using System.Collections.Generic;
using System.Linq;

namespace Birthday_Cake_Candles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(birthdayCakeCandles(new List<int> { 3 ,2, 1, 3 }));
        }
        public static int birthdayCakeCandles(List<int> candles)
        {
            var max = candles.Max();
            return candles.Where(c => c == max).Count();
        }
    }
}
