using System;
using System.Linq;

namespace P03.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rowsCols = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(rowsCols[0]);
            int cols = int.Parse(rowsCols[1]);
            int[ ,] matrix= new int[rows, cols];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currRow = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currRow[j];
                }
            }
            int biggestSum=int.MinValue;
            int[ ,] biggestSumMatrix= new int[3,3];
            for (int i = 0; i < rows-2; i++)
            {
                for (int j = 0; j < cols-2; j++)
                {
                    int currSum = matrix[i, j]
                                  + matrix[i+1, j]
                                  + matrix[i, j+1]
                                  + matrix[i+1, j+1]
                                  + matrix[i+2, j]
                                  + matrix[i+2, j+1]
                                  + matrix[i, j+2]
                                  + matrix[i+1, j+2]
                                  + matrix[i+2, j+2];
                    if (currSum>biggestSum)
                    {
                        biggestSum = currSum;
                        for (int k = i; k < rows; k++)
                        {
                            if (k -i> 2)
                            {
                                break;
                            }
                            for (int l = j; l < cols; l++)
                            {
                                if (l-j>2)
                                {
                                    break;
                                }
                                biggestSumMatrix[k - i, l - j] = matrix[k, l];
                            }
                            
                        }
                    }
                }
            }

            Console.WriteLine($"Sum = {biggestSum}");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(biggestSumMatrix[i,j]+" ");
                }

                Console.WriteLine();
            }
        }
    }
}
