/*
You are running a classroom and suspect that some of your students are passing around the answer to a multiple-choice question disguised as a random string.

Your task is to write a function that, given a list of words and a string, finds and returns the word in the list that is scrambled inside the string, if any exists. If none exist, it returns the result "-" as a string. There will be at most one matching word. The letters don't need to be in order or next to each other. The letters cannot be reused.

Example:  
words = ["baby", "referee", "cat", "dada", "dog", "bird", "ax"]
string1 = "ctay"
find(words, string1) => "cat"   (the letters do not have to be in order)  
  
string2 = "bcanihjsrrrferet"
find(words, string2) => "cat"   (the letters do not have to be together)  
  
string3 = "tbaykkjlga"
find(words, string3) => "-"     (the letters cannot be reused)  
  
string4 = "bbbblkkjbaby"
find(words, string4) => "baby"    
  
string5 = "dad"
find(words, string5) => "-"    
  
string6 = "breadmaking"
find(words, string6) => "bird"    

All Test Cases:
find(words, string1) -> "cat"
find(words, string2) -> "cat"
find(words, string3) -> "-"
find(words, string4) -> "baby"
find(words, string5) -> "-"
find(words, string6) -> "bird"
  
Complexity analysis variables:  
  
W = number of words in `words`  
S = maximal length of each word or string  
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Solution {
    static void Main(String[] args) {
       var words = new string[] {"baby", "referee", "cat", "dada", "dog", "bird", "ax"};
        var string1 = "ctay";
        var string2 = "bcanihjsrrrferet";        
        var string3 = "tbaykkjlga";
        var string4 = "bbbblkkjbaby";
        var string5 = "dad";
        var string6 = "breadmaking";
        
        Console.WriteLine("string1: " + find(words, string1));
        Console.WriteLine("string2: " + find(words, string2));
        Console.WriteLine("string3: " + find(words, string3));
        Console.WriteLine("string4: " + find(words, string4));
        Console.WriteLine("string5: " + find(words, string5));
        Console.WriteLine("string6: " + find(words, string6));
    }
    
    static string find(string[] words, string string1){
        
        for (var i = 0 ; i < words.Length ; i++)
        {
            if (words[i].Length > string1.Length)
                continue;
            
            var hash = new HashSet<char>();
            
            foreach (var item in words[i].ToCharArray())
                hash.Add(item);                
            
            hash.IntersectWith(string1);

            var groupBy = words[i].GroupBy(item => item);
            
            if (hash.Count() < groupBy.Count())
                continue;
            
            var qttIsOk = true;
            
            foreach (var item in groupBy.Where(x => x.Count() > 1))
            {
                if (string1.Count(x => x == item.Key) < item.Count())
                {
                    qttIsOk = false;
                    break;
                }
            }

            if (!qttIsOk)
                continue;

            return words[i];
        }

        return "-";
    }
}