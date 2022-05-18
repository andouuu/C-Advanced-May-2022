using System;
using System.Collections.Generic;
using System.Linq;


namespace P05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < input.Length; i++)
            {
                queue.Enqueue(input[i]);
            }

            while (queue.Count>0)
            {
                if (queue.Peek()%2==0)
                {
                    Console.Write(queue.Dequeue());
                    if (queue.Count>0)
                    {
                        Console.Write(", ");
                        
                    }continue;
                }

                queue.Dequeue();
            }
        }
    }
}
