using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {
        static void Main(string[] args) {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(8);
            queue.Enqueue(20);
            queue.Enqueue(23);

            int removedItem = queue.Dequeue();
            Console.WriteLine(removedItem);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());

            int current;
            while(queue.TryDequeue(out current)) {
                Console.WriteLine(current);
            }

        }
    }
}