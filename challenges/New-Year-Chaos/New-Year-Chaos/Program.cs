using System;
using System.Collections.Generic;
using System.Linq;

namespace New_Year_Chaos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //minimumBribes(new List<int> { 2, 1, 3, 4, 5 });
            //minimumBribes(new List<int> { 2, 3, 1, 4, 5 });
            //minimumBribes(new List<int> { 2, 3, 4, 1, 5 });
            //minimumBribes(new List<int> { 2, 3, 4, 5, 1 });
            //minimumBribes(new List<int> { 3, 2, 1, 4, 5 });
            //                            1  2  3  4  5  6  7  8
            minimumBribes(new List<int> { 1, 2, 5, 3, 7, 8, 6, 4 });
        }
        public static void minimumBribes(List<int> q)
        {
            int minBribes = 0;
            int min1 = int.MaxValue;
            int min2 = int.MaxValue;
            // start from rightmost person and move left
            for (int i = q.Count - 1; i >= 0; i--)
            {
                int sticker = q[i];
                int currentPosition = i - 1;
                if (sticker - currentPosition > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }

                if (sticker > min1)
                {
                    minBribes++;
                }

                if (sticker > min2)
                {
                    minBribes++;
                }

                //update min values
                if (sticker < min1 || sticker < min2)
                {
                    if (min1 > min2)
                    {
                        min1 = sticker;
                    }
                    else
                    {
                        min2 = sticker;
                    }
                }
            }
            Console.WriteLine(minBribes);
        }
    }
}
