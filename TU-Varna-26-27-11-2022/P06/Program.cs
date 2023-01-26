namespace P06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                int p=int.Parse(input[0]);
                int b=int.Parse(input[1]);
                int x=int.Parse(input[2]);
                int y=int.Parse(input[3]);
                int pxCombos = 0;
                int byCombos=0;
                foreach (var combination in Combinations(p,x))
                {
                    pxCombos++;
                }
                foreach (var combination in Combinations(b, y))
                {
                    byCombos++;
                }

                Console.WriteLine(pxCombos*byCombos);
            }
        }
        private static IEnumerable<int[]> Combinations(int pb, int xy)
        {
            var result = new int[pb];
            var stack = new Stack<int>();
            stack.Push(1);

            while (stack.Count > 0)
            {
                var index = stack.Count - 1;
                var value = stack.Pop();

                while (value <= xy)
                {
                    result[index++] = value++;
                    stack.Push(value);
                    if (index == pb)
                    {
                        yield return result;
                        break;
                    }
                }
            }
        }
    }
}