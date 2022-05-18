using System;
using System.Collections.Generic;

namespace P06.Supermarker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            string cmd;
            while ((cmd=Console.ReadLine())!="End")
            {
                if (cmd=="Paid")
                {
                    while (queue.Count>0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    continue;
                }
                queue.Enqueue(cmd);
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
