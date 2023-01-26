using System.Diagnostics.CodeAnalysis;

namespace P03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            byte[] originalBoxes = new byte[n * 2];
            for (byte i = 1; i <= 2 * n; i++)
            {
                originalBoxes[i - 1] = i;
            }
            int k = 1;
            bool isWin = false;
            List<byte> boxes= new List<byte>();
            int currIndex;
            while (isWin == false)
            {
                currIndex = 0;
                boxes.AddRange(originalBoxes);
                while (boxes.Exists(x => x > n))
                {
                    currIndex = (currIndex+k)%boxes.Count;
                    if (boxes[currIndex] <= n)
                    {
                        isWin = false;
                        break;
                    }
                    boxes.RemoveAt(currIndex);
                    isWin = true;
                }
                boxes.Clear();
                k++;
            }
            Console.WriteLine(k);
        }
    }
}