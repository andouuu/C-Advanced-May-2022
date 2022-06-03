using System;
using System.IO;

namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\example.png";
            string joinedFilePath = @"..\..\..\example-joined.png";
            string partOnePath = @"..\..\..\part-1.bin";
            string partTwoPath = @"..\..\..\part-2.bin";
            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            // TODO: write your code here… 
            byte[] allBytes = File.ReadAllBytes(sourceFilePath);
            byte[] first;
            if (allBytes.Length%2!=0)
            {
                first = new byte[allBytes.Length/2+1];  
            }
            else
            { 
                first = new byte[allBytes.Length / 2];
            }

            Array.Copy(allBytes, first, first.Length);
            byte[] second = new byte[allBytes.Length - first.Length];
            Array.Copy(allBytes, first.Length, second, 0, second.Length);
            using (var p1 = new FileStream(partOneFilePath, FileMode.Create))
            {
                using (var p2=new FileStream(partTwoFilePath,FileMode.Create))
                {
                    p1.Write(first);
                    p2.Write(second);
                }
            }
        }
        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            // TODO: write your code here… 
            byte[] allBytes1 = File.ReadAllBytes(partOneFilePath);
            byte[] allBytes2 = File.ReadAllBytes(partTwoFilePath);
            
            using (var fs=new FileStream(joinedFilePath,FileMode.Create))
            {
                fs.Write(allBytes1,0,allBytes1.Length);
                fs.Write(allBytes2,0,allBytes2.Length);
            }
                
        }
    }
}
