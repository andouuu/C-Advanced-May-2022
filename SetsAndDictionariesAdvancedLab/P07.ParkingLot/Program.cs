using System;
using System.Collections.Generic;

namespace P07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set=new HashSet<string>();
            string cmd;
            while ((cmd=Console.ReadLine())!="END")
            {
                string[] tokens = cmd.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string type=tokens[0];
                string numberPlate=tokens[1];
                if (type == "IN")
                    set.Add(numberPlate);
                else if (type=="OUT")
                {
                    if (set.Contains(numberPlate))
                        set.Remove(numberPlate);
                }
            }

            if (set.Count>0)
            {
                Console.WriteLine(string.Join(Environment.NewLine,set));
            }
            else
            {
                Console.WriteLine($"Parking Lot is Empty");
            }
        }
    }
}
