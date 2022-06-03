using System;
using System.IO;

namespace CopyDirectory
{
    using System;
    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";
            CopyAllFiles(inputPath, outputPath);
        }
        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            DirectoryInfo directory = new DirectoryInfo(inputPath);
            FileInfo[] files = directory.GetFiles();
            if (Directory.Exists(outputPath))
                Directory.Delete(outputPath,true);
            Directory.CreateDirectory(outputPath);
            foreach (var fileInfo in files)
            {
                string targetFilePath = Path.Combine(outputPath, fileInfo.Name);
                fileInfo.CopyTo(targetFilePath);
            }
        }
    }
}