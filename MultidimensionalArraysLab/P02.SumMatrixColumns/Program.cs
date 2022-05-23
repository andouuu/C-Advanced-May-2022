using System;
using System.Linq;

namespace P02.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowCols[0];
            int cols = rowCols[1];
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currRow[j];
                }
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int currSum = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    currSum+=matrix[j,i];
                }

                Console.WriteLine(currSum);
            }
        }
    }
}
