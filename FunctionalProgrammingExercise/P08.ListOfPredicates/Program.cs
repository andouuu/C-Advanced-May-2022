using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            List<int> output= new List<int>();
            bool isTrue = true;
            for (int i = 1; i <= n; i++)
            {
                foreach (var divider in dividers)
                {
                   Predicate<int> predicate=x=>x% divider==0;
                   if (!predicate.Invoke(i))
                   {
                       isTrue=false;
                   }
                }

                if (isTrue==true)
                {
                    output.Add(i);
                }

                isTrue = true;

            }

            Console.WriteLine(string.Join(" ",output));
        }
    }
}
