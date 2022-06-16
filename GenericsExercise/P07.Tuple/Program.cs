using System;

namespace P07.Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tup1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Tuple<string[], string> firsTuple = new Tuple<string[], string>(new string[2] { tup1[0], tup1[1] }, tup1[2]);
            string[] tup2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Tuple<string,int> secondTuple = new Tuple<string, int>(tup2[0], int.Parse(tup2[1]));
            string[] tup3 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Tuple<int,double> thirdTuple = new Tuple<int, double>(int.Parse(tup3[0]), double.Parse(tup3[1]));
            Console.WriteLine($"{string.Join(" ",firsTuple.Item1) } -> {firsTuple.Item2}");
            Console.WriteLine($"{secondTuple.Item1} -> {secondTuple.Item2}");
            Console.WriteLine($"{thirdTuple.Item1} -> {thirdTuple.Item2}");
        }
    }
}
