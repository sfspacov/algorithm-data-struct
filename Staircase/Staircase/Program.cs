using System;

namespace Staircase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            staircase(6);
        }

        public static void staircase(int n)
        {
            for (int i = n - 1; i > -1; i--)
            {
                var aux = n - (i);
                Console.Write(new string(' ', i));
                Console.WriteLine(new string('#', aux));
            }
        }
    }
}
