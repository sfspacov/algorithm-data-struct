using System;
using System.Collections.Generic;
using System.Timers;

namespace affirmingwords
{
    class MainClass
    {
        static Random random = new Random();
        static List<string> encouragements = new List<string>()
        {
            "Way to go!",
            "Keep it up!",
            "Almost there!",
            "You're doing great!"
        };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to start the timer!");
            Console.ReadLine();

            // MARK: Result
            StartTimer(3);

            Console.WriteLine("You can end the timer anytime by pressing ENTER.\n");
            Console.ReadLine();
            StopTimer();
        }

        // MARK: Write your solution here...
        public static void StartTimer(int interval)
        {

        }

        // 6
        public static void StopTimer()
        {

        }
    }
}