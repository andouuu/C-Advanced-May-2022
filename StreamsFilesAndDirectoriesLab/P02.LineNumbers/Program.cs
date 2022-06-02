using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\input.txt";
            string outputPath = @"..\..\..\output.txt";
            RewriteFileWithLineNumbers(inputPath, outputPath);
        }
        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            // TODO: write your code here… 
            StreamReader reader=new StreamReader(inputFilePath);
            using (reader)
            {
                
                int line = 1;
                string currLine = reader.ReadLine();
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                     while (currLine!=null)
                     {
                        writer.WriteLine($"{line}. {currLine}");
                        line++;
                        currLine = reader.ReadLine();
                     }
                }
               
            }
        }

    }

}
