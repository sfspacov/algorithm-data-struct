using System;
using System.Linq;

namespace ContainsDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContainsDuplicate(new int[] { 1, 2, 3, 1 });
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            var g = nums.GroupBy(x => x);
            var result = g.Any(x => x.Count() > 2);
            return result;
        }
    }
}