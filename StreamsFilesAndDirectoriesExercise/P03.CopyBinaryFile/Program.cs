

namespace CopyBinaryFile
{
    using System;
    using System.IO;
    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";
            CopyFile(inputFilePath, outputFilePath);
        }
        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (var fs1=new FileStream(inputFilePath,FileMode.Open))
            {
                using (var fs2=new FileStream(outputFilePath,FileMode.Create))
                {
                    byte[] buffer = new byte[fs1.Length];
                    fs1.Read(buffer, 0, buffer.Length);
                    fs2.Write(buffer);
                }
            }
        }

    }

}
