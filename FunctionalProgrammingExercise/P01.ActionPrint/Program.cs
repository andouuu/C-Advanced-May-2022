using System;
using System.Threading.Channels;

namespace P01.ActionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string> action = item => Console.WriteLine(item);
            foreach (var s in input)
            {
                action.Invoke(s);
            }
        }
    }
}
