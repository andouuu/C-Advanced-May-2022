using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();
            DateModifier dateModifier = new DateModifier();
            dateModifier.Days(date1, date2);
            Console.WriteLine(Math.Abs(dateModifier.DaysBetweenDates));
        }
    }
}
