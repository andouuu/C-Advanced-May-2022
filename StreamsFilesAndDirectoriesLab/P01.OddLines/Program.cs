using System;
using System.IO;

namespace OddLines

{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\input.txt";
            string outputFilePath = @"..\..\..\output.txt";
            ExtractOddLines(inputFilePath, outputFilePath);
        }
        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            // TODO: write your code here… 
            StreamReader readInput = new StreamReader(inputFilePath);
            using (readInput)
            {
                int lines = 0;
                string currLine=readInput.ReadLine();
                using (StreamWriter writeOutput = new StreamWriter(outputFilePath))
                {
                    while (currLine != null)
                    {
                        if (lines % 2 == 1)
                            writeOutput.WriteLine(currLine);
                        lines++;
                        currLine = readInput.ReadLine();
                    }
                }
            }
        }

    }

}
