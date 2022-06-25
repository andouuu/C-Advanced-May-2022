using System;
using System.Collections.Generic;
using System.Linq;

namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whiteTiles = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            Queue<int> greyTiles = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"Countertop", 0},
                {"Floor", 0},
                {"Oven", 0},
                {"Sink", 0},
                {"Wall", 0}
            };
        while (whiteTiles.Count>0&&greyTiles.Count>0)
            {
                int lastWhiteTile=whiteTiles.Peek();
                int firstGreyTile = greyTiles.Peek();
                whiteTiles.Pop();
                greyTiles.Dequeue();
                if (firstGreyTile == lastWhiteTile)
                {
                    int sum = firstGreyTile + lastWhiteTile;
                    if (sum == 40)
                    {
                        dict["Sink"]++;
                    }
                    else if (sum == 50)
                    {
                        dict["Oven"]++;
                    }
                    else if (sum == 60)
                    {
                        dict["Countertop"]++;
                    }
                    else if (sum == 70)
                    {
                        dict["Wall"]++;
                    }
                    else
                    {
                        dict["Floor"]++;
                    }
                }
                else
                {
                    lastWhiteTile /= 2;
                    whiteTiles.Push(lastWhiteTile);
                    greyTiles.Enqueue(firstGreyTile);
                }
            }
            
            
            if (whiteTiles.Count==0)
                Console.WriteLine($"White tiles left: none");
            else
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteTiles)}");

            if (greyTiles.Count == 0)
                Console.WriteLine($"Grey tiles left: none");
            else
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");

            foreach (var i in dict.OrderByDescending(x=>x.Value)
                .ThenBy(x=>x.Key).Where(x=>x.Value>0))
            {
                Console.WriteLine($"{i.Key}: {i.Value}");
            }
        }
    }
}
