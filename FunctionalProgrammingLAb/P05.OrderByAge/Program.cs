using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace P05.OrderByAge
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ReadPeople();
            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            string[] format = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Func<Person, bool> filter = CreateFilter(condition, ageThreshold);
            Action<Person> printer = CreatePrinter(format);
            PrintFilteredPeople(people, filter, printer);
        }

        static List<Person> ReadPeople()
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                Person person= new Person();
                string[] currPerson = Console.ReadLine().Split(", ");
                person.name = currPerson[0];
                person.age = int.Parse(currPerson[1]);
                people.Add(person);
            }

            return people;
        }

        static Func<Person, bool> CreateFilter(string condition, int ageThreshold)
        {
            Func<Person, bool> filter = null;
            if (condition == "older")
            {
                filter = x => x.age >= ageThreshold;
            }
            else
            {
                filter = x => x.age < ageThreshold;
            }
            return filter;
        }

        static Action<Person> CreatePrinter(string[] format)
        {
            Action<Person> printer = null;
            if (format.Length == 1 && format[0]=="name")
            {
                printer=x => Console.WriteLine(x.name);
            }
            else if (format.Length == 1 && format[0]=="age")
            {
                printer = x => Console.WriteLine(x.age);
            }
            else
            {
                printer = x => Console.WriteLine(x.name+" - "+x.age);
            }

            return printer;
        }

        static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
        {
            
            foreach (var person in people)
            {
                if (filter.Invoke(person))
                {
                    printer.Invoke(person);
                }
                
            }
        }
    }
}
