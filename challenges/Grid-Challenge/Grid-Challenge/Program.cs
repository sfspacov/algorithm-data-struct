using System;
using System.Collections.Generic;
using System.Linq;

namespace Grid_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(gridChallenge(new List<string> { "ppp", "ypp", "wyw" }));
        }

        public static string gridChallenge(List<string> grid)
        {
            var inverse = new List<string>();

            for (int i = 0; i < grid.Count; i++)
            {
                grid[i] = string.Concat(grid[i].OrderBy(x => x));
            }

            for (int i = 0; i < grid.Count; i++)
                for (int j = i; j < grid[i].Length - 1; j++)
                {
                    if (grid[j][i] > grid[j + 1][i])
                    {
                        return "NO";
                    }
                }

            return "YES";
        }
    }
}
