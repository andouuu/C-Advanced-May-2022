using System;
using System.Linq;

namespace DefiningClasses
{
    public class DateModifier
    {


        public int DaysBetweenDates;
        

        public int Days(string date1, string date2)
        {
            
            int[] splitDate1 = date1.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] splitDate2 = date2.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            DateTime dateOne = new DateTime(splitDate1[0], splitDate1[1], splitDate1[2]);
            DateTime dateTwo = new DateTime(splitDate2[0], splitDate2[1], splitDate2[2]);
            DaysBetweenDates = dateTwo.Subtract(dateOne).Days;
            return DaysBetweenDates;
        }
    }
}