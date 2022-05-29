using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.AverageStudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,List<decimal>> students=new Dictionary<string,List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] currInput=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string currStudent=currInput[0];
                decimal currGrade = decimal.Parse(currInput[1]);
                if (!students.ContainsKey(currStudent))
                    students[currStudent]=new List<decimal>();
                students[currStudent].Add(currGrade);
                
            }

            foreach (var student in students)
            {
                //John -> 5.20 3.20 (avg: 4.20) 
                string name = student.Key;
                List<decimal> grades=student.Value;
                var average = grades.Average();
                Console.Write($"{name} -> ");
                foreach (var grade in grades)
                    Console.Write($"{grade:f2} ");
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
