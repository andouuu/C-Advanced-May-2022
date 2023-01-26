namespace P04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                byte[] xny = Console.ReadLine().Split().Select(byte.Parse).ToArray();
                byte x = xny[0];
                byte n = xny[1];
                byte y = xny[2];
                int[] nums= new int[x];
                for (int j = 0; j < x; j++)
                {
                    nums[j] = j;
                }
                List<int[]> uniqueRows= new List<int[]>();
                int[] arrayToAdd= new int[n];
                while (true)
                {
                    Console.WriteLine($"({string.Join(", ", arrayToAdd.Select(e => nums[e]))})");

                    var index = n - 1;
                    while (index >= 0 && arrayToAdd[index] == x - 1)
                    {
                        index--;
                    }
                    if (index < 0)
                    {
                        break;
                    }
                    arrayToAdd[index]++;
                    for (int l = index + 1; l < n; l++)
                    {
                        arrayToAdd[i] = 0;
                    }
                }
                for (int k=0; k < uniqueRows.Count; k++)
                {
                    int sum=0;
                    for (int j = 0; j < uniqueRows[k].Length; j++)
                    {
                        sum += uniqueRows[k][j];
                    }
                    if (sum>=y)
                    {
                        uniqueRows.Remove(uniqueRows[k]);
                        k=-1;
                    }
                }
                Console.WriteLine(uniqueRows.Count);
            }
        }
        
    }
}