using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            string cmd = Console.ReadLine();
            while (cmd!="end")
            {
                //"add"->add 1 to each number
                if (cmd == "add")
                {
                    List<int> newList= input.Select(x => x += 1).ToList();
                    input=newList;
                }
                //"multiply"->multiply each number by 2
                else if (cmd=="multiply")
                {
                    List<int> newList = input.Select(x => x *= 2).ToList();
                    input = newList;
                }
                //"subtract"->subtract 1 from each number
                else if (cmd == "subtract")
                {
                    List<int> newList = input.Select(x => x -= 1).ToList();
                    input = newList;
                }
                //"print"->print the collection
                else if (cmd=="print")
                {Console.WriteLine(string.Join(" ",input));}
                //"end"->ends the input
                cmd = Console.ReadLine();
            }
        }
    }
}
