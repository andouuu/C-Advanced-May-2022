
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    using System;
    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";
            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);
            WriteReportToDesktop(reportContent, reportFileName);
        }
        public static string TraverseDirectory(string inputFolderPath)
        {
            Dictionary<string,Dictionary<string,double>> files=new Dictionary<string,Dictionary<string,double>>();
            string[] filesInDir = Directory.GetFiles(inputFolderPath);
            string output = string.Empty;
            foreach (var file in filesInDir)
            {
                FileInfo fileInfo = new FileInfo(file);
                var extension=fileInfo.Extension;
                double lenghtOfFile=fileInfo.Length/1024;
                if (files.ContainsKey(extension))
                {
                    files[extension].Add(file,lenghtOfFile);
                }
                else
                {
                    files.Add(extension,new Dictionary<string, double>());
                    files[extension].Add(file, lenghtOfFile);
                }
            }

            files.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Value.Keys)
                .ThenBy(x=>x.Value.Values);
            string valuesString=string.Empty;
            foreach (var file in files)
            {
                foreach (var item in file.Value)
                {
                    valuesString += $"--{item.Key} - {item.Value}kb"+"\r\n";
                }
                output += file.Key + "\r\n" + valuesString;
                valuesString = string.Empty;
            }

            return output;
        }
        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+reportFileName;
            File.WriteAllText(desktopPath,textContent);

        }
    }
}
