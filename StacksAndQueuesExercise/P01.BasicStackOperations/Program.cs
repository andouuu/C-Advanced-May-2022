using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cmd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = cmd[0];
            int s = cmd[1];
            int x = cmd[2];
            Stack<int> stack = new Stack<int>();
            int[] input=Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < n; i++)
            {
                stack.Push(input[i]);
            }

            for (int i = 0; i < s; i++)
            {
                if (stack.Count==0)
                {
                    break;
                }
                stack.Pop();
            }

            if (stack.Count==0)
                Console.WriteLine(0);
            else if (stack.Contains(x))
                Console.WriteLine("true");
            else
                Console.WriteLine(stack.Min());
            
        }
    }
}
