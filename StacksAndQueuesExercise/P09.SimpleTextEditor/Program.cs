using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace P09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            Stack<string> commands = new Stack<string>();
            string output=string.Empty;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split();
                if (cmd[0]=="1")
                {stack.Push(output);
                    output += cmd[1];
                    
                }
                else if (cmd[0] == "2")
                {stack.Push(output);
                    output=output.Substring(0,output.Length-int.Parse(cmd[1]));
                    
                }
                else if (cmd[0]=="3")
                {
                    Console.WriteLine(output[int.Parse(cmd[1])-1]);
                }
                else if (cmd[0] == "4")
                {
                    output=stack.Pop();
                }
                
            }
        }
    }
}
