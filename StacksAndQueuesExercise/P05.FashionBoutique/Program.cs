using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);
            int capacity = int.Parse(Console.ReadLine());
            int sum=0;
            double rackCount=1;
            while (sum < capacity && stack.Count > 0)
            {
                if (sum + stack.Peek() == capacity)
                {
                    stack.Pop();
                    sum = 0;
                    if (stack.Count > 0)
                        rackCount++;
                    continue;
                }
                if (sum + stack.Peek() > capacity)
                {
                    sum = 0;
                    rackCount++;
                    continue;
                }
                sum += stack.Pop();
            }
            //for (int i = 0; i < input.Length; i++)
            //{
            //    sum += stack.Pop();
            //}
            //if (capacity!=0)
            //{ 
            //    rackCount += Math.Ceiling((double)sum / capacity);
            //}


            Console.WriteLine(rackCount);
            
            
        }
    }
}
