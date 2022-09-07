using System;
using System.Collections.Generic;
using System.Linq;

namespace Group_Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs.Length == 1)
            {
                return new List<IList<string>>() { strs };
            }
            var dic = new List<Tuple<string, string>>();
            var result = new List<List<string>>();
            foreach (var item in strs)
            {
                dic.Add(new Tuple<string, string>(item, string.Concat(item.OrderBy(x => x).ToArray())));
            }
            string lastItem = null;

            foreach (var item in dic.OrderBy(x => x.Item2))
            {
                if (item.Item2 != lastItem)
                {
                    result.Add(new List<string>() { item.Item1 });
                    lastItem = item.Item2;
                }
                else
                {
                    result.Last().Add(item.Item1);
                }
            }

            return new List<IList<string>>(result);
        }
    }
}
