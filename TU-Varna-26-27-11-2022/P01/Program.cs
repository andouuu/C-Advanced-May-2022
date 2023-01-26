using Console = System.Console;

namespace P01
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            string STDIN = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());
            string lastNChars = STDIN.Substring(STDIN.Length - N, N);
            STDIN= STDIN.Substring(0, STDIN.Length - N);
            STDIN = lastNChars+STDIN;
            string STDOUT = string.Empty;
            for (int i = 0; i < STDIN.Length; i++)
            {
                char newchar = (char)((int)STDIN[i] + N);
                STDOUT+=newchar;
            }

            Console.WriteLine(STDOUT);
        }
    }
}