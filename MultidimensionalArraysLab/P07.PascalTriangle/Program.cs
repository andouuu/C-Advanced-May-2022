using System;

namespace P07.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] jagArr=new long[n][];
            for (int i = 0; i < n; i++)
            {
                jagArr[i] = new long[i+1];
                jagArr[i][0] = 1;
                jagArr[i][i] = 1;
                if (i>1)
                {
                    for (int j = 1; j < i; j++)
                    {
                        jagArr[i][j] = jagArr[i - 1][j - 1] + jagArr[i - 1][j];
                    }
                }
            }

            foreach (var arr in jagArr)
            {
                Console.WriteLine(string.Join(" ",arr));
            }
        }
    }
}
