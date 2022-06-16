using System;
using System.Linq;

namespace P08.Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string[] tup1 = input1.Split(" ");
            Threeuple<string[], string, string[]> firsTuple = new Threeuple<string[], string, string[]>(new string[2] { tup1[0], tup1[1] }, tup1[2], tup1.Skip(3).ToArray());

            string[] tup2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            bool drunkOrNot=tup2[2]=="drunk";
            Threeuple<string, int,bool> secondTuple = new Threeuple<string, int,bool>(tup2[0], int.Parse(tup2[1]),drunkOrNot);

            string[] tup3 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Threeuple<string, double,string> thirdTuple = new Threeuple<string, double,string>(tup3[0], double.Parse(tup3[1]), tup3[2]);

            Console.WriteLine($"{string.Join(" ", firsTuple.Item1)} -> {firsTuple.Item2} -> {string.Join(" ",firsTuple.Item3)}");
            Console.WriteLine($"{secondTuple.Item1} -> {secondTuple.Item2} -> {secondTuple.Item3}");
            Console.WriteLine($"{thirdTuple.Item1} -> {thirdTuple.Item2} -> {thirdTuple.Item3}");
        }
    }
}
