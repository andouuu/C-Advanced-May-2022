using System;
using System.Collections.Generic;

namespace P05.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string,List<string>>> continents=new Dictionary<string,Dictionary<string,List<string>>>();
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                string[] tokens = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string continent = tokens[0];
                string currCountry = tokens[1];
                string currCity = tokens[2];
                if (!continents.ContainsKey(continent))
                {
                    continents[continent] = new Dictionary<string, List<string>>();
                    continents[continent].Add(currCountry, new List<string>() { currCity });
                }
                else
                {
                    if (!continents[continent].ContainsKey(currCountry))
                        continents[continent][currCountry]= new List<string>();
                    continents[continent][currCountry].Add(currCity);
                }  
                
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }
    }
}
