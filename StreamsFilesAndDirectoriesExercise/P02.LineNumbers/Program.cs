using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";
            ProcessLines(inputFilePath, outputFilePath);
        }
        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            using (var reader = new StreamReader(inputFilePath))
            {
                using (var writer = new StreamWriter(outputFilePath))
                {
                    string currLine = reader.ReadLine();
                    int currLineNum = 1;
                    while (currLine != null)
                    {
                        int countPunctuationMarks = 0;
                        int countLetters = 0;
                        foreach (var item in currLine)
                        {
                            if (!char.IsLetterOrDigit(item) && item != ' ')
                                countPunctuationMarks++;
                            else if (char.IsLetterOrDigit(item) && item != ' ')
                                countLetters++;


                        }


                        //Line 1: -I was quick to judge him, but it wasn't his fault. (37)(4)
                        writer.WriteLine($"Line {currLineNum}: {currLine} ({countLetters})({countPunctuationMarks})");
                        currLineNum++;
                        currLine = reader.ReadLine();
                    }
                }
            }
        }
    }
}

