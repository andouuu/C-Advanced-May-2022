using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            for (int k = i; k <= j; k++)
            {
                int iSwap = arr[k];
                arr[k] = arr[j];
                arr[j] = iSwap;
                j--;
            }

            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
