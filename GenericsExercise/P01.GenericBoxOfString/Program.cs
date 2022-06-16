using System;
using P01.GenericBoxOfString;

namespace P01P02.GenericBoxOfStringAndInt
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //// P01
            //Box<string> box = new Box<string>();
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    box.data.Add(Console.ReadLine());
            //}
            //Console.WriteLine(box.ToString());


            ////P02
            Box<int> intBox = new Box<int>();
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                intBox.data.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(intBox.ToString());
        }
    }
}
