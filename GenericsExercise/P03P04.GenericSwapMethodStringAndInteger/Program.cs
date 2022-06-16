using System;
using System.Linq;

namespace P03P04.GenericSwapMethodStringAndInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //P03
            Box<string> stringBox=new Box<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                stringBox.data.Add(Console.ReadLine());
            }

            int[] swapIndexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            stringBox.SwapPlaces(swapIndexes[0], swapIndexes[1]);
            Console.WriteLine(stringBox.ToString());
        }
    }
}
