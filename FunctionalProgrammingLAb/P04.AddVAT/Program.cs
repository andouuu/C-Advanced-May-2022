using System;
using System.Linq;

namespace P04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\r\n",
                Console.ReadLine()
                    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .Select(x=>x*=1.2)
                    .Select(x=>$"{x:f2}")));
        }
    }
}
