using System;
using System.Linq;

namespace P07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Predicate<string> predicate = x => x.Length <= n;
            string[] inputNames = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var name in inputNames)
            {
                if (predicate.Invoke(name))
                    Console.WriteLine(name);    
            }
        }
    }
}
