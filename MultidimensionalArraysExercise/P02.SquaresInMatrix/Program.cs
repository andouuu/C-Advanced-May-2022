using System;
using System.Linq;

namespace P02.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rowCol = Console.ReadLine().Split();
            int rows = int.Parse(rowCol[0]);
            int cols = int.Parse(rowCol[1]);
            string[,] matrix = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] currRow = Console.ReadLine().Split();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = currRow[j];
                }
            }
            int squareCount=0;
            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols-1; j++)
                {
                    if (matrix[i, j] == matrix[i+1,j]&&matrix[i,j]==matrix[i+1,j+1]&&matrix[i,j]==matrix[i,j+1])
                    {
                        squareCount++;
                    }
                }
            }

            Console.WriteLine(squareCount);
        }
    }
}
