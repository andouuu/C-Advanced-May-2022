using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EvenLines
{
    using System;
    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            Console.WriteLine(ProcessLines(inputFilePath));
        }
        public static string ProcessLines(string inputFilePath)
        {
            List<string> output = new List<string>();
                int lineCount=0;
            using (var reader=new StreamReader(inputFilePath))
            {
                string currLine=reader.ReadLine();
                while (currLine != null)
                {
                    if (lineCount%2==0)
                        output.Add(currLine);
                    lineCount++;
                    currLine=reader.ReadLine();
                }
            }
            List<string[]> lines = new List<string[]>();
            foreach (var line in output)
            {
                string line2=line.Replace('-', '@').Replace(',', '@').Replace('.', '@').Replace('!', '@').Replace('?', '@');
                string[] currLine=line2.Split(' ');
                Array.Reverse(currLine);
                lines.Add(currLine);
            }
            string finalOutput=String.Empty;
            foreach (var line in lines)
            {
                finalOutput+=string.Join(" ",line)+"\r\n";
            }

            return finalOutput;
        }

    }

}
