using System;
using System.Linq;

namespace ProductExceptSelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach (var item in ProductExceptSelf(new int[] { 1, 2, 3, 4 }))
            //    Console.Write(item + ", ");

            //Console.WriteLine();
            //Console.WriteLine();

            foreach (var item in ProductExceptSelf(new int[] { 0,0 }))
                Console.Write(item + ", ");
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];
            for (var i = 0; i < nums.Length; i++)
            {
                var value = 0;

                if (nums[i] == 0)
                {
                    if (i == 0)
                    {
                        value = nums.Skip(1).Take(nums.Length - 1).Aggregate(1, (a, b) => a * b);
                    }
                    else if (i == nums.Length - 1)
                    {
                        value = nums.Take(nums.Length - 1).Aggregate(1, (a, b) => a * b);
                    }
                    else
                    {
                        value = nums.Take(i).Concat(nums.Skip(i+1).Take(nums.Length - 1)).Aggregate(1, (a, b) => a * b);
                    }
                }
                else if (nums[i] != 0)
                {
                    value = nums.Aggregate(1, (a, b) => a * b);
                    value /= nums[i];
                }
                else if (nums[i] < 0)
                {
                    value /= nums[i] * (-1);
                }
                result[i] = value;
            }
            return result;
        }
    }
}
