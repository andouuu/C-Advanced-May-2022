using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            Func<int[], int[]> reverseArr = x => x.Reverse().ToArray();
            Func<int,bool> removeNums = x => x % n != 0; 
            arr=reverseArr.Invoke(arr);
            int[] arr2 = arr.Where(removeNums).ToArray();

            Console.WriteLine(string.Join(" ",arr2));
        }
    }
}
