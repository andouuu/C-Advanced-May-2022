using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> durjavi = Console.ReadLine().Split(",").ToList();
            Console.WriteLine(string.Join(" ",durjavi));
            int broi=0;
            for (int i = 0; i < durjavi.Count; i++)
            {
                if (durjavi[i][0]=='A')
                {
                    durjavi.Remove(durjavi[i]);
                    broi++;
                    i = -1;
                }
            }

            if (broi==0)
            {
                Console.WriteLine("There are not a country beginning with 'A' in the list.");
            }
            else
            {
                Console.WriteLine(broi);
            }

            Console.WriteLine(string.Join(";",durjavi));
        }
    }
}
