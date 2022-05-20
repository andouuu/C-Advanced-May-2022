using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cmd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = cmd[0];
            int s = cmd[1];
            int x = cmd[2];
            Queue<int> queue = new Queue<int>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(input[i]);
            }

            for (int i = 0; i < s; i++)
            {
                if (queue.Count == 0)
                {
                    break;
                }
                queue.Dequeue();
            }

            if (queue.Count == 0)
                Console.WriteLine(0);
            else if (queue.Contains(x))
                Console.WriteLine("true");
            else
                Console.WriteLine(queue.Min());
        }
    }
}
