using System;
using System.Collections.Generic;

namespace P03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements=new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] currElements=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < currElements.Length; j++)
                {
                    elements.Add(currElements[j]);
                }
            }
            Console.WriteLine(string.Join(" ",elements));
        }
    }
}
