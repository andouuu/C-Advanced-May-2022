using System;
using System.Collections.Generic;

namespace P03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>();
            for (int i = input.Length-1; i >=0; i--)
            {
                stack.Push(input[i]);
            }
            int result=int.Parse(stack.Pop());
            while (stack.Count>0)
            {
                if (stack.Peek()=="-")
                {
                    stack.Pop();
                    result -= int.Parse(stack.Pop());
                }
                else if (stack.Peek()=="+")
                {
                    stack.Pop();
                    result += int.Parse(stack.Pop());
                }
            }

            Console.WriteLine(result);
        }
    }
}
