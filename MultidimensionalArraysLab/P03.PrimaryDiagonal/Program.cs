using System;
using System.Linq;

namespace P03.PrimaryDiagonal
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
                for (int j = 0; j < n; j++)
                {
                    matrix[i,j] = currRow[j];
                }
            }
            int sum=0;
            for (int i = 0; i < n; i++)
            {
                sum+=matrix[i,i];
            }

            Console.WriteLine(sum);
        }
    }
}
