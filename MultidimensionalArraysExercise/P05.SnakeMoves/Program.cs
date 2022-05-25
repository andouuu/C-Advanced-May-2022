using System;
using System.Linq;

namespace P05.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = rowCol[0];
            int cols = rowCol[1];
            string[ ,] matrix=new string[rows, cols];
            string snake = Console.ReadLine();
            int currSnakeIndex=0;
            for (int i = 0; i < rows; i++)
            {
                if (i%2==0)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (currSnakeIndex > snake.Length - 1)
                        {
                            currSnakeIndex = 0;
                        }
                        matrix[i, j] = snake[currSnakeIndex].ToString();
                        currSnakeIndex++;
                    }
                }
                else
                {
                    for (int j = cols-1; j >= 0; j--)
                    {
                        if (currSnakeIndex>snake.Length-1)
                        {
                            currSnakeIndex = 0;
                        }
                        matrix[i, j] = snake[currSnakeIndex].ToString();
                        currSnakeIndex++;
                    }
                }
                
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i,j]);
                }

                Console.WriteLine();
            }
        }
    }
}
