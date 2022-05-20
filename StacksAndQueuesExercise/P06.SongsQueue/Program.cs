using System;
using System.Collections.Generic;

namespace P06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(input);
            
            
            while (queue.Count > 0) 
            {
                string cmd = Console.ReadLine();
                string[] command = cmd.Split();
                string cmdType=command[0];
                switch (cmdType)
                {
                    case "Add":
                        string songToAdd=cmd.Remove(cmd.IndexOf(command[0]),command[0].Length+1);
                        if (queue.Contains(songToAdd))
                        {
                            Console.WriteLine($"{songToAdd} is already contained!");
                        }
                        else
                        {
                           queue.Enqueue(songToAdd); 
                        }
                        break;
                    case "Play":
                        queue.Dequeue();
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",queue));
                        break;
                }

                
            }

            Console.WriteLine($"No more songs!");
        }
    }
}
