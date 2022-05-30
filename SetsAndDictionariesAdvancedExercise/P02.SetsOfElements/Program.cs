using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            int n = input[0];
            int m = input[1];
            HashSet<int> nSet=new HashSet<int>();
            HashSet<int> mSet=new HashSet<int>();
            var finalSet=new HashSet<int>();
            for (int i = 0; i < n; i++)
                nSet.Add(int.Parse(Console.ReadLine()));
            for (int i = 0; i < m; i++)
                mSet.Add(int.Parse(Console.ReadLine()));
            foreach (var item in nSet)
            {
                if (mSet.Contains(item))
                    finalSet.Add(item);
            }

            Console.WriteLine(string.Join(" ",finalSet));
        }
    }
}
