using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace P03.CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\r\n",Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Where(x => char.IsUpper(x[0]))));
        }
    }
}
