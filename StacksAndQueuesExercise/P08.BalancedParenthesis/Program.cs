using System;
using System.Collections.Generic;

namespace P08.BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = Console.ReadLine().ToCharArray();
            Stack<char> brackets = new Stack<char>();
            bool isBalanced = true;

            foreach (var item in charArray)
            {
                bool isClosingBracket = item == ')' || item == '}' || item == ']';
                bool isOpeningBracket = item == '[' || item == '{' || item == '(';
                if (isBalanced)
                {
                    if (isOpeningBracket)
                    {
                        brackets.Push(item);
                    }
                    else if (isClosingBracket&&brackets.Count>0)
                    {
                        if (((int)item == (int)(brackets.Peek() + 1)) || ((int)item == ((int)(brackets.Peek() + 2))))
                        {
                            brackets.Pop();
                        }
                        else
                        {
                            isBalanced = false;
                        }
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
            }
            if (isBalanced && brackets.Count==0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
