using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarirame opashkata
            Queue<int> queue = new Queue<int>();
            //deklarirame i klasut random
            Random random = new Random();
            //vzimame ot konzolata chislo N
            int n=int.Parse(Console.ReadLine());
            //pravim for cikul, koito da se vurti N puti
            for (int i = 0; i < n; i++)
            {
                //vkarvame v opashkata sluchaino chislo ot intervala [10,300]
                queue.Enqueue(random.Next(10,301));
                //vtoroto e 301 zashtoto poslednoto ne se broi toest se broqt samo chislata do 300
            }
            //izvejdame opashkata
            Console.WriteLine(string.Join(" ",queue));
            //deklarirame chetna i nechetna suma
            int evenSum = 0;
            int oddSum = 0;
            //preminavame prez vseki element i go proverqvame dali e chetno ili neshetno
            foreach (int i in queue)
            {
                if (i%2==0)
                {
                    evenSum += i;
                }
                else
                {
                    oddSum+=i;
                }
            }
            //izpisvame proizvedenieto na dvete sumi
            Console.WriteLine(evenSum*oddSum);
        }
    }
}
