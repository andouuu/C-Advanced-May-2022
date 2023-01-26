namespace P07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int n = input[0];
                if (n<=3||n>=101)
                {
                    break;
                }
                int m=input[1];
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int bestSum=0;
                int currSum;
                for (int i = 0; i < n-2; i++)
                {
                    for (int j = 1; j < n-1; j++)
                    {
                        for (int k = 2; k < n; k++)
                        {
                            if (k == j || k == i || j == i)
                            {
                                continue;
                            }

                            currSum = numbers[i] 
                                      + numbers[j]
                                      + numbers[k];
                            if (currSum>bestSum&&currSum<=m)
                            {
                                bestSum=currSum;
                            }
                        }
                    } 
                }

                Console.WriteLine(bestSum);
            }
            
        }
    }
}