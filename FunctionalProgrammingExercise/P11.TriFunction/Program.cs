using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace P11.TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .First(y=>y.Select(x=>(int)x).Sum()>=n));
        }
    }
}
