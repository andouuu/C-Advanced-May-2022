using System;
using System.Linq;

namespace P05.SquareWithMaximumSum
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
                int[] currRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currRow[j];
                }
            }

            int maxSum = int.MinValue;
            string output = string.Empty;
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    int currSum=matrix[i, j]+matrix[i,j+1]+matrix[i+1,j]+matrix[i+1,j+1];
                    if (currSum>maxSum)
                    {
                        maxSum = currSum;
                        output=$"{matrix[i, j]} {matrix[i, j+1]}"+Environment.NewLine+$"{matrix[i+1, j]} {matrix[i+1, j+1]}";
                        
                    }
                }
            }

            Console.WriteLine(output);
            Console.WriteLine(maxSum);
        }
    }
}
