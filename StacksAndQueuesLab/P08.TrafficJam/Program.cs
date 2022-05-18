using System;
using System.Collections.Generic;

namespace P08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue=new Queue<string>();
            string cmd;
            int countPassed = 0;
            while ((cmd=Console.ReadLine())!="end")
            {
                if (cmd=="green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count==0)
                        {
                            break;
                        }

                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        countPassed++;
                    }
                    continue;
                }
                queue.Enqueue(cmd);

            }

            Console.WriteLine($"{countPassed} cars passed the crossroads.");
        }
    }
}
