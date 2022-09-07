using System;

namespace Tower_Breakers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private int TowerBreakers(int n, int m)
        {
            return m == 1 || n % 2 == 0 ? 2 : 1;
        }
    }
}
