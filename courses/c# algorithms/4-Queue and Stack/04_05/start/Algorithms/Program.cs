using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    class Program
    {

        static void Main(string[] args)
        {
            NextGreater(new int[] { 15, 8, 4, 10 });
            NextGreater(new int[] { 2 });
            NextGreater(new int[] { 2, 3 });
            NextGreater(new int[] { });
        }

        static void NextGreater(int[] arr)
        {
            if (arr.Length <= 0)
                return;

            var stack = new Stack<int>();
            stack.Push(arr[0]);

            foreach (var item in arr.Skip(1))
            {
                while (stack.Any() && item > stack.Peek())
                    Console.WriteLine($"{stack.Pop()} -> {item}");
                stack.Push(item);
            }

            while (stack.Any())
                Console.WriteLine($"{stack.Pop()} -> -1");
        }
    }
}