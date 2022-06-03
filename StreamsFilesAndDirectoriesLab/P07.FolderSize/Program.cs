using System;
using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\TestFolder";
            string outputPath = @"..\..\..\output.txt";
            GetFolderSize(folderPath, outputPath);
        }
        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            // TODO: write your code here… 
            double sum = 0;
            DirectoryInfo dir= new DirectoryInfo(folderPath);
            FileInfo[] files= dir.GetFiles("*",SearchOption.AllDirectories);
            foreach (var fileInfo in files)
            {
                sum += fileInfo.Length;
            }

            sum = sum / 1024 ;
            File.WriteAllText(outputFilePath,sum.ToString() + " KB");
        }
    }
}