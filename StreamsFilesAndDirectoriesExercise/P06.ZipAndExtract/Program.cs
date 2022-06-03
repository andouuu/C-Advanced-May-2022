using System;
using System.IO.Compression;
using System.Net.Http.Headers;
using System.Xml.Schema;

namespace ZipAndExtract
{
    using System;
    using System.IO;
    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string zipArchiveFilePath = @"..\..\..\archive.zip";
            string outputFilePath = @"..\..\..\extracted.png";
            ZipFileToArchive(inputFilePath,zipArchiveFilePath);

            var fileNameOnly = Path.GetFileName(inputFilePath);
            ExtractFileFromArchive(zipArchiveFilePath,fileNameOnly,outputFilePath);
        }
        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            using (var archive=ZipFile.Open(zipArchiveFilePath,ZipArchiveMode.Create))
            {
                string fileName = Path.GetFileName(inputFilePath);
                archive.CreateEntryFromFile(inputFilePath, fileName);
            }
            

        }
        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
           var archive= ZipFile.OpenRead(zipArchiveFilePath);
           ZipArchiveEntry fileForExtraction = archive.GetEntry(fileName);
           fileForExtraction.ExtractToFile(outputFilePath);
        }
    }
}
