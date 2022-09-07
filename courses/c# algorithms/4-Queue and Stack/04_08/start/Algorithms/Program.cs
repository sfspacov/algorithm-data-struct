using System;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        const char l_parenteses = '(';
        const char r_parenteses = ')';
        static bool hasMatchingParentheses(string s)
        {
            var stack = new Stack<char>();
            foreach (var item in s)
                if (item == l_parenteses)
                    stack.Push(item);
                else if (item == r_parenteses)
                    if (stack.Count != 0)
                        stack.Pop();
                    else
                        return false;

            return stack.Count == 0;
        }

        //Only works because with have JUST PARENTHESES. If we had other chars, STACK is needed!
        static bool hasMatchingParentheses2(string s)
        {
            int stack = 0;
            foreach (var item in s)
                if (item == l_parenteses)
                    stack++;
                else if (item == r_parenteses)
                    if (stack != 0)
                        stack--;
                    else
                        return false;

            return stack == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(hasMatchingParentheses("((hello()))"));
            Console.WriteLine(hasMatchingParentheses("()(hello())"));
            Console.WriteLine(hasMatchingParentheses("((hello))"));
            Console.WriteLine(hasMatchingParentheses("(hello)"));

            Console.WriteLine();

            Console.WriteLine(hasMatchingParentheses("(hello("));
            Console.WriteLine(hasMatchingParentheses(")hello)"));
            Console.WriteLine(hasMatchingParentheses(")hello("));
            Console.WriteLine(hasMatchingParentheses("hello(("));
            Console.WriteLine(hasMatchingParentheses("(hello"));
            Console.WriteLine(hasMatchingParentheses("((hello)"));
        }
    }
}