using System;

namespace P04.SymbolinMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                string currRow = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = currRow[j];
                }
            }

            char symbolToSearch = char.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j]==symbolToSearch)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbolToSearch} does not occur in the matrix");
        }
    }
}
