using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {

        static void Main(string[] args)
        {
            var ll = new LinkedList<string>();
            ll.AddLast("Sarah");
            ll.AddLast("Fernanda");
            ll.AddLast("Mariah");
            ll.AddLast("Sandra");
            ll.AddLast("Cris");

            Console.WriteLine(ll.Contains("Polly"));
            Console.WriteLine(ll.Count);

            ll.RemoveFirst();

            foreach (var item in ll)
            {
                Console.Write(item + "->");
            }
            Console.WriteLine();
        }
    }
}