using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {

        static void Main(string[] args) {
            NumberFrequency(new int[]{1,1,1,1,2,3,4,4,4,5,5,87});
        }

        static void NumberFrequency(int[] a){
            var dic = new Dictionary<int,int>();
            foreach (var item in a)
            {
                if (dic.ContainsKey(item))
                    dic[item]++;
                else
                    dic.Add(item,1);                
            }

            foreach (var x in dic)
                    Console.WriteLine($"{x.Key}: {x.Value}");
        }
    }
}