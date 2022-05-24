using System;
using System.Globalization;
using System.Linq;

namespace P06.JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagArr= new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                jagArr[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            string[] cmd = Console.ReadLine().Split();
            while (cmd[0]!="END")
            {
                string cmdType = cmd[0];
                
                if (int.Parse(cmd[1])>=rows
                    || int.Parse(cmd[1]) < 0
                    || int.Parse(cmd[2]) < 0
                    ||jagArr[int.Parse(cmd[1])].Length< int.Parse(cmd[2]))
                {
                    Console.WriteLine($"Invalid coordinates");
                }
                else if (cmdType=="Add")
                {
                    int currRow = int.Parse(cmd[1]);
                    int currCol = int.Parse(cmd[2]);
                    int currVal = int.Parse(cmd[3]);
                    jagArr[currRow][currCol] += currVal;
                }
                else if (cmdType=="Subtract")
                {
                    int currRow = int.Parse(cmd[1]);
                    int currCol = int.Parse(cmd[2]);
                    int currVal = int.Parse(cmd[3]);
                    jagArr[currRow][currCol]-=currVal;
                }
                cmd = Console.ReadLine().Split();
            }

            foreach (int[] arr in jagArr)
            {
                Console.WriteLine(string.Join(" ",arr));
                
            }
        }
    }
}
