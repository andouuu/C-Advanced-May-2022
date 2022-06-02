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
            StreamReader readInput=new StreamReader(inputFilePath);
            using (readInput)
            {
                int line =0;
                StreamWriter writeOutput=new StreamWriter(outputFilePath);
                using (writeOutput)
                {
                    if (readInput.ReadLine()==null)
                        return;
                    

                    if (line%2==1)
                        writeOutput.WriteLine(readInput.ReadLine());
                    line++;
                }
            }
        }

    }

}
