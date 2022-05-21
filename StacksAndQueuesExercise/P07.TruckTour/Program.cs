using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();
            for (int i = 0; i < n; i++)
            {
                int [] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(arr);
            }
            
            int index = 0;
            while (true)
            {
                bool isValidPump = true;
                int petrolLeft=0;
                foreach (var pump in queue)
                {
                    
                    int currPumpPetrol = pump[0];
                    int nextPumpDistance=pump[1];
                    petrolLeft += currPumpPetrol;
                    if (petrolLeft>=nextPumpDistance)
                    {
                        petrolLeft-=nextPumpDistance;
                    }
                    else
                    {
                        int[] currPump=queue.Dequeue();
                        index++;
                        queue.Enqueue(currPump);
                        isValidPump = false;
                        break;
                    }
                }

                if (isValidPump)
                {
                    Console.WriteLine(index);
                    break;
                }
                
            }

            
        }
    }
}
