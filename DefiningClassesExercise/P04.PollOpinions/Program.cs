using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people=new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] currPerson=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                people.Add(new Person(currPerson[0], int.Parse(currPerson[1])));
            }

            foreach (var person in people.OrderBy(x => x.Name).Where(x => x.Age > 30))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
