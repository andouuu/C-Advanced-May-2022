using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double,int> dict=new Dictionary<double,int>();
            double[] input = Console.ReadLine() 
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (dict.ContainsKey(input[i]))
                {
                    dict[input[i]]++;
                }
                else
                {
                    dict.Add(input[i],1);
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
