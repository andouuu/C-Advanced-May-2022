using System;
using System.Linq;

namespace P04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bonds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            string cmd = Console.ReadLine();
            Predicate<int> evenPredicate = x => x % 2 == 0;
            Predicate<int> oddPredicate= x => x % 2 != 0;
            if (cmd=="even")
            {
                for (int i = bonds[0]; i <= bonds[1]; i++)
                {
                    if (evenPredicate.Invoke(i))
                    {Console.Write(i+" ");}
                }
            }

            if (cmd=="odd")
            {
                for (int i = bonds[0]; i <= bonds[1]; i++)
                {
                    if (oddPredicate.Invoke(i))
                    {Console.Write(i+" ");}
                }
            }
        }
    }
}
