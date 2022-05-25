using System;
using System.Collections.Immutable;
using System.Linq;

namespace P01.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] currRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = currRow[j];
                }
            }
            int primarySum=0;
            int secondarySum=0;
            for (int i = 0; i < n; i++)
            {
                primarySum+=matrix[i,i];
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i+j==n-1)
                    {
                        secondarySum+=matrix[i,j];
                    }
                }
            }

            Console.WriteLine(Math.Abs(primarySum-secondarySum));
        }
    }
}
