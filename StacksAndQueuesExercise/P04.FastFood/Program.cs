using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] clients = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue=new Queue<int>(clients);
            Console.WriteLine(queue.Max());
            while (queue.Count>0)
            {
                if (quantityOfFood >= queue.Peek())
                {
                    quantityOfFood-=queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queue.Count==0)
            {
                Console.WriteLine($"Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ",queue)}");
            }
        }
    }
}
