using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c=='(')
                {
                    stack.Push(i);
                }
                else if (c == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                    Console.WriteLine(input.Substring(startIndex,endIndex-startIndex+1));
                }
            }
        }
    }
}
