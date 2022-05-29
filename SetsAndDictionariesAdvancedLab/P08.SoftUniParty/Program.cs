using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd;
            HashSet<string> set=new HashSet<string>();
            
            while ((cmd=Console.ReadLine())!="PARTY")
            {
                set.Add(cmd);
            }

            string secondCmd;
            while ((secondCmd = Console.ReadLine()) != "END")
            {
                set.Remove(secondCmd);
            }

            Console.WriteLine(set.Count);
            foreach (var code in set)
            {
                if (char.IsDigit(code[0]))
                {
                    Console.WriteLine(code);
                }
            }
            foreach (var code in set)
            {
                if (!char.IsDigit(code[0]))
                {
                    Console.WriteLine(code);
                }
            }
        }
    }
}
