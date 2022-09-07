using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static int[] FindEvenNums(int[] arr1, int[] arr2)
        {
            var result = new ArrayList();
            var t1 = Task.Run(() =>
            {
                foreach (var item in arr1)
                {
                    if (item % 2 == 0)
                        result.Add(item);
                }
            });
            var t2 = Task.Run(() =>
            {
                foreach (var item in arr2)
                {
                    if (item % 2 == 0)
                        result.Add(item);
                }
            });
            
            t1.Wait();
            t2.Wait();

            return (int[])result.ToArray(typeof(int));
        }

        static void Main(string[] args)
        {
            int[] arr1 = { -8, 2, 3, -9, 11, -20 };
            int[] arr2 = { 0, -2, -9, -39, 39, 10, 7 };

            int[] evenArr = FindEvenNums(arr1, arr2);
            Array.ForEach(evenArr, x => Console.WriteLine(x));
        }
    }
}