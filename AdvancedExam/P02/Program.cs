using System;

namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int holeCount=1;
            int rodCount=0;
            for (int i = 0; i < n; i++)
            {
                string currRow = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = currRow[j];
                }
            }
            int vankosCol=-1; 
            int vankosRow=-1;
            string movement;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j]=='V')
                    {
                        vankosRow = i;
                        vankosCol = j;
                        break;
                    }
                }

                if (vankosCol!=-1&&vankosRow!=-1)
                {
                    break;
                }
            }
            while ((movement=Console.ReadLine())!="End")
            {
                int oldRow = vankosRow;
                int oldCol = vankosCol;
                switch (movement)
                {
                    case "up":
                        if (vankosRow!=0)
                        {
                            matrix[vankosRow, vankosCol] = '*';
                            holeCount++;
                            vankosRow--;
                        }
                        break;
                    case "down":
                        if (vankosRow != n-1)
                        {
                            matrix[vankosRow, vankosCol] = '*';
                            holeCount++;
                            vankosRow++;
                        }
                        break;
                    case "left":
                        if (vankosCol != 0)
                        {
                            matrix[vankosRow, vankosCol] = '*';
                            holeCount++;
                            vankosCol--;
                        }
                        break;
                    case "right":
                        if (vankosCol != n-1)
                        {
                            matrix[vankosRow, vankosCol] = '*';
                            holeCount++;
                            vankosCol++;
                        }
                        break;
                }
                if (matrix[vankosRow,vankosCol]=='R')
                {
                    vankosRow = oldRow;
                    vankosCol = oldCol;
                    Console.WriteLine("Vanko hit a rod!");
                    matrix[vankosRow,vankosCol] = 'V';
                    
                    rodCount++;
                    holeCount--;
                }
                else if (matrix[vankosRow,vankosCol]=='C')
                {
                    
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCount} hole(s).");
                    matrix[vankosRow, vankosCol] = 'E';
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(matrix[i,j]);
                        }

                        Console.WriteLine();
                    }
                    return;
                }
                else if (matrix[vankosRow,vankosCol]=='*')
                {
                    Console.WriteLine($"The wall is already destroyed at position [{vankosRow}, {vankosCol}]!");
                    matrix[vankosRow, vankosCol] = 'V';
                    holeCount--;
                }
                else if(matrix[vankosRow, vankosCol] == '-')
                {
                    matrix[vankosRow, vankosCol] = 'V';
                }
            }

            Console.WriteLine($"Vanko managed to make { holeCount} hole(s) and he hit only { rodCount} rod(s).");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
