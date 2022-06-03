using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\words.txt";
            string textPath = @"..\..\..\text.txt";
            string outputPath = @"..\..\..\output.txt";
            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            // TODO: write your code here… 
            StreamReader wordsReader= new StreamReader(wordsFilePath);
            using (wordsReader)
            {
                List<string> words = wordsReader.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
                Dictionary<string,int> wordsCount=new Dictionary<string,int>();
                foreach (string word in words)
                {
                    wordsCount.Add(word,0);
                }
                StreamReader textReader = new StreamReader(textFilePath);
                using (textReader)
                {
                    string currLine=textReader.ReadLine();
                    while (currLine != null)
                    {
                        currLine = Regex.Replace(currLine, "[^a-zA-Z0-9 ]", String.Empty);
                        string[] currWords=currLine.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                        foreach (var word in currWords)
                        {
                            if (wordsCount.ContainsKey(word.ToLower()))
                                wordsCount[word.ToLower()]++;
                        }
                        currLine=textReader.ReadLine();
                    }
                }
                StreamWriter outputStreamWriter = new StreamWriter(outputFilePath);
                using (outputStreamWriter)
                {
                    foreach (var i in wordsCount.OrderByDescending(x=>x.Value))
                    {
                        outputStreamWriter.WriteLine($"{i.Key} - {i.Value}");
                    }
                }
            }
        }
    }

}
