using System;

namespace P07.KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, n];
            for (int i = 0; i < n; i++)
            {
                string input=Console.ReadLine();
                char[] currRow=input.ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = currRow[j].ToString();
                }
            }
            int countOfKingsToRemove=0;
            int[] coordinatesOfBiggestKnight=new int[]{-1,-1};
            int biggestKingCount = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int currKingCount=0;
                    if (matrix[i,j]=="K")
                    {
                        if (i+2<n&&j-1>=0)
                        {
                           if (matrix[i+2,j-1]=="K")
                           {
                                currKingCount++;
                           } 
                        }
                        if (i + 2 < n && j + 1 <n )
                        { 
                            if (matrix[i + 2, j + 1] == "K")
                            {
                                currKingCount++;
                            }
                        }
                        if (i -2 >=0 && j - 1 >= 0)
                        {
                            if (matrix[i - 2, j - 1] == "K")
                            {
                                currKingCount++;
                            }
                        }
                        if (i - 2 >=0 && j + 1 < n)
                        {
                            if (matrix[i - 2, j + 1] == "K")
                            {
                                currKingCount++;
                            }
                        }
                        if (j + 2 < n && i - 1 >= 0)
                        {
                            if (matrix[i - 1, j + 2] == "K")
                            {
                                currKingCount++;
                            }
                        }
                        if (j + 2 < n && i + 1 < n)
                        {
                            if (matrix[i + 1, j + 2] == "K")
                            {
                                currKingCount++;
                            }
                        }
                        if (j - 2 >=0 && i - 1 >= 0)
                        {
                            if (matrix[i - 1, j - 2] == "K")
                            {
                                currKingCount++;
                            }
                        }
                        if (j -2>=0 && i + 1 < n)
                        {
                            if (matrix[i + 1, j - 2] == "K")
                            {
                                currKingCount++;
                            }
                        }
                        if (currKingCount>biggestKingCount)
                        {
                            biggestKingCount = currKingCount;
                            coordinatesOfBiggestKnight = new int[] {i, j};
                        }
                    }
                }

                if (coordinatesOfBiggestKnight[0]==-1)
                {
                    
                }
                else if(i==n-1&&matrix[coordinatesOfBiggestKnight[0],coordinatesOfBiggestKnight[1]]=="K")
                {
                    matrix[coordinatesOfBiggestKnight[0], coordinatesOfBiggestKnight[1]] = "0";
                    i=-1;
                    countOfKingsToRemove++;
                    biggestKingCount = 0;
                    coordinatesOfBiggestKnight = new int[] {-1, -1};
                }
            }

            Console.WriteLine(countOfKingsToRemove);
        }
    }
}
