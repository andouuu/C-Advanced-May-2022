

using System.Linq;

namespace ExtractBytes
{
    using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
    public class ExtractBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\example.png";
            string bytesFilePath = @"..\..\..\bytes.txt";
            string outputPath = @"..\..\..\output.bin";
            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            // TODO: write your code here… 
            byte[] allBytes=File.ReadAllBytes(binaryFilePath);
            using (var reader=new StreamReader(bytesFilePath))
            {
                List<byte> byteList = new List<byte>();
                string currLine=reader.ReadLine();
                while (currLine != null)
                {
                    byteList.Add(byte.Parse(currLine));
                    currLine = reader.ReadLine();
                }
                byte[] buffer2 = byteList.ToArray();
                using (FileStream output=new FileStream(outputPath,FileMode.Create))
                {
                    foreach (var b in allBytes)
                    {
                        if (buffer2.Contains(b))
                        {
                            output.WriteByte(b);
                        }
                    }
                }
            }
            
        }
    }
}
