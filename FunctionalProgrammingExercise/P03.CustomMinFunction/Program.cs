using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace P03.CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            Func<int[], int> minFunc = x => x.Min();
            Console.WriteLine(minFunc.Invoke(inputNums));
        }
    }
}
