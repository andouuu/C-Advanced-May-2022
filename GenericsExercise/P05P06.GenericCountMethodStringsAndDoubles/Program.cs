using System;
using System.Collections.Generic;

namespace P05P06.GenericCountMethodStringsAndDoubles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //P05
            //int n = int.Parse(Console.ReadLine());
            //List<string> list = new List<string>();
            //for (int i = 0; i < n; i++)
            //{
            //    list.Add(Console.ReadLine());
            //}
            //Box<string> stringBox = new Box<string>(list);
            //string elToCompare = Console.ReadLine();
            //int count = stringBox.CountGreaterElements(stringBox.data, elToCompare);
            //Console.WriteLine(count);




            //P06
            int n = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }
            Box<double> stringBox = new Box<double>(list);
            double elToCompare = double.Parse(Console.ReadLine());
            int count = stringBox.CountGreaterElements(stringBox.data, elToCompare);
            Console.WriteLine(count);
        }
    }
}
