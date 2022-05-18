using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(inputNums);
            string[] command=Console.ReadLine().Split();
            while (command[0].ToLower()!="end")
            {
                string cmdType=command[0].ToLower();
                if (cmdType=="add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else if (cmdType == "remove")
                {
                    if (!(int.Parse(command[1])>stack.Count)&&!(int.Parse(command[1])<0))
                    {
                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
