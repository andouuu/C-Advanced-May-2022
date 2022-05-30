using System;
using System.Collections.Generic;

namespace P04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> numbers=new Dictionary<int,int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(currNum))
                    numbers.Add(currNum,1);
                else
                    numbers[currNum]+=1;
            }

            foreach (var number in numbers)
            {
                if (number.Value%2==0)
                {
                    Console.WriteLine(number.Key);
                    break;  
                }
            }
        }
    }
}
