using System;

namespace P02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string> action = item => Console.WriteLine("Sir "+item);
            foreach (var s in input)
            {
                action.Invoke(s);
            }
        }
    }
}
