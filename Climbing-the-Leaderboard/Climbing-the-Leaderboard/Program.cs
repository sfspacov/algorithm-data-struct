using System;
using System.Collections.Generic;
using System.Linq;

namespace Climbing_the_Leaderboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //climbingLeaderboard(
            //    new List<int> { 100, 90, 90, 80, 75, 60 },
            //    new List<int> { 50, 65, 77, 90, 102 });

            climbingLeaderboard(
                new List<int> { 100, 100, 50, 40, 40, 20, 10 },
                new List<int> { 5, 25, 50, 120 });
        }

        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            var result = new List<int>();

            ranked = ranked.Distinct().ToList();

            foreach (var score in player)
            {
                if (ranked.Any(x => x == score))
                {
                    result.Add(ranked.IndexOf(score) + 1);
                    continue;
                }
                var index = ranked.Count(x => x > score);
                result.Add(index + 1);
            }

            return result;
        }
    }
}
