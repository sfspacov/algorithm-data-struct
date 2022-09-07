using System;

namespace Time_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(timeConversion("07:05:45PM"));
        }

        public static string timeConversion(string s)
        {
            var time = DateTime.Parse(s).ToLongTimeString();
            return time;
        }
    }
}
