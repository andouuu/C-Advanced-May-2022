using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace P04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rowsCols = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(rowsCols[0]);
            int cols = int.Parse(rowsCols[1]);
            string[,] matrix = new string[rows, cols];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] currRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currRow[j];
                }
            }

            string pattern = @"^swap [0-9]+ [0-9]+ [0-9]+ [0-9]+$";
            Regex regex = new Regex(pattern);
            string cmd;
            while ((cmd=Console.ReadLine())!="END")
            {
                if (!regex.IsMatch(cmd))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                string[] command=cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int row1=int.Parse(command[1]);
                int col1=int.Parse(command[2]);
                int row2=int.Parse(command[3]);
                int col2=int.Parse(command[4]);
                if (row1>rows-1
                    ||row2>rows-1
                    ||col1>cols-1
                    ||col2>cols-1
                    || row1 <0
                    || row2 <0
                    || col1 <0
                    || col2 <0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string oldElement = matrix[row1, col1];
                matrix[row1,col1]=matrix[row2, col2];
                matrix[row2,col2]=oldElement;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }

            
        }
    }
}
