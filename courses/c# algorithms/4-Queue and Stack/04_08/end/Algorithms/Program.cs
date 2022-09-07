using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {
        
         static Boolean hasMatchingParentheses(string s) {
             Stack<char> stack = new Stack<char>();

             for (int i = 0; i < s.Length; i++) {
                 char current = s[i];

                 if (current == '(') {
                     stack.Push(current);
                     continue;
                 }

                 if (current == ')') {
                     if (stack.Count > 0) {
                         stack.Pop();
                     } else {
                         return false;
                     }
                 }
             }

             return stack.Count == 0;
        }

        static Boolean hasMatchingParentheses2(string s) {
            int matchingSymbolTracker = 0;
             for (int i = 0; i < s.Length; i++) {
                 char current = s[i];

                 if (current == '(') {
                     matchingSymbolTracker++;
                     continue;
                 }

                 if (current == ')') {
                     if (matchingSymbolTracker > 0) {
                         matchingSymbolTracker--;
                     } else {
                         return false;
                     }
                 }
             }

             return matchingSymbolTracker == 0;
        }

        static void Main(string[] args) {
            Console.WriteLine(hasMatchingParentheses2("((hello()))"));
            Console.WriteLine(hasMatchingParentheses2("()(hello())"));
            Console.WriteLine(hasMatchingParentheses2("((hello))"));
            Console.WriteLine(hasMatchingParentheses2("(hello)"));

            Console.WriteLine();

            Console.WriteLine(hasMatchingParentheses2("(hello("));
            Console.WriteLine(hasMatchingParentheses2(")hello)"));
            Console.WriteLine(hasMatchingParentheses2(")hello("));
            Console.WriteLine(hasMatchingParentheses2("hello(("));
            Console.WriteLine(hasMatchingParentheses2("(hello"));
            Console.WriteLine(hasMatchingParentheses2("((hello)"));
        }
    }
}