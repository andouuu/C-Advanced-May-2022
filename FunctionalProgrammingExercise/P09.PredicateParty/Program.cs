using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace P09.PredicateParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string cmd = Console.ReadLine();
            
            while (cmd!="Party!")
            {
                Predicate<string> predicate=null;
                string[] command=cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType=command[0];
                string cmdName=command[1];
                string cmdValue=command[2];
                if (cmdType == "Remove")
                {
                    
                    if (cmdName=="StartsWith")
                    {
                        predicate = str => str.StartsWith(cmdValue);
                    }
                    else if (cmdName=="EndsWith")
                    {
                        predicate = str => str.EndsWith(cmdValue);
                    }
                    else if (cmdName == "Length")
                    {
                        predicate = str => str.Length == int.Parse(cmdValue);
                    }

                    people.RemoveAll(predicate);
                }
                else if (cmdType == "Double")
                {
                    if (cmdName == "StartsWith")
                    {
                        predicate = str => str.StartsWith(cmdValue);
                    }
                    else if (cmdName == "EndsWith")
                    {
                        predicate = str => str.EndsWith(cmdValue);
                    }
                    else if (cmdName == "Length")
                    {
                        predicate = str => str.Length == int.Parse(cmdValue);
                    }

                    for (var index = 0; index < people.Count; index++)
                    {
                        var person = people[index];
                        if (predicate(person))
                        {
                            people.Insert(index + 1, person);
                            index++;
                        }

                        
                    }
                }
                cmd = Console.ReadLine();
            }

            if (people.Count>0)
            {
                Console.WriteLine($"{string.Join(", ",people)} are going to the party!");
            }
            else
            {
                Console.WriteLine($"Nobody is going to the party!");
            }
        }
    }
}
