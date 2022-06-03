using System;
using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\input1.txt";
            var secondInputFilePath = @"..\..\..\input2.txt";
            var outputFilePath = @"..\..\..\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            // TODO: write your code here…
            StreamReader reader1 = new StreamReader(firstInputFilePath);
            StreamReader reader2 = new StreamReader(secondInputFilePath);
            using (reader1)
            {
                using (reader2)
                {
                    var currLine1 = reader1.ReadLine();
                    var currLine2 = reader2.ReadLine();
                    StreamWriter writer= new StreamWriter(outputFilePath);
                    using (writer)
                    {
                        while (currLine1 != null && currLine2 != null)
                        {
                            writer.WriteLine(currLine1);
                            writer.WriteLine(currLine2);
                            currLine1 = reader1.ReadLine();
                            currLine2 = reader2.ReadLine();
                        }
                        if (currLine1 == null)
                        {
                            while (currLine2 != null)
                            {
                                writer.WriteLine(currLine2);
                                currLine2 = reader2.ReadLine();
                            }
                        }
                        else
                        {
                            while (currLine1 != null)
                            {
                                writer.WriteLine(currLine1);
                                currLine1 = reader1.ReadLine();
                            }
                        }
                    }
                    
                }
            }
        }
    }
}
