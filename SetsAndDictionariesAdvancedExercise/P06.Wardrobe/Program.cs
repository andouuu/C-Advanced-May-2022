using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string,int>> wardrobe=new Dictionary<string,Dictionary<string,int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] currInputs=Console.ReadLine().Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                string color=currInputs[0];
                string[] currClothes = currInputs[1].Split(",");
                if (!wardrobe.ContainsKey(color))
                    wardrobe[color] = new Dictionary<string, int>();
                for (int j = 0; j < currClothes.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(currClothes[j]))
                        wardrobe[color].Add(currClothes[j],1);
                    else
                        wardrobe[color][currClothes[j]] += 1;
                }
            }

            string[] found = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string foundColor=found[0];
            string foundClothes=found[1];
            //"{color} clothes: 
            //* { item1} - { count}
            //* { item2} - { count}
            //* { item3} - { count}
            foreach (var clothes in wardrobe)
            {
                Console.WriteLine($"{clothes.Key} clothes:");
                foreach (var kvp in clothes.Value)
                {
                    if (clothes.Key==foundColor&&kvp.Key==foundClothes)
                        Console.WriteLine($"* {kvp.Key} - {kvp.Value} (found!)");
                    else
                        Console.WriteLine($"* {kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}
