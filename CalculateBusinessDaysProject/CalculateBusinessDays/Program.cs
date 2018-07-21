using System;
using System.Linq;

namespace CalculateBusinessDays
{
    public static class Program
    {
        // More ideal to use an API to get the public holidays
        // But for this excercise its fine to hardcode them
        public static readonly string[] PublicHolidays = {
            "01/01/2018",
            "30/03/2018",
            "02/04/2018",
            "07/05/2018",
            "28/05/2018",
            "27/08/2018",
            "25/12/2018",
            "26/12/2018"
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static DateTime AddDateInBusinessdays(DateTime date, int numOfDays)
        {
            DateTime calculatedDate = Program.AddDays(date, numOfDays);
            return calculatedDate;
        }

        private static DateTime AddDays(DateTime date, int endValue, int value = 1)
        {
            if (endValue < 1) {
                return date;
            }

            DayOfWeek dayOfWeek = date.DayOfWeek;
            DayOfWeek isSaturday = DayOfWeek.Saturday;
            String dateString = date.ToString("dd/MM/yyyy");

            if (dayOfWeek != isSaturday) {
                date = date.AddDays(1);
            }

            // Add one more day if the date is on a public holiday
            if (PublicHolidays.Any(dateString.Contains))
            {
                date = date.AddDays(1);
            }

            if (date.DayOfWeek == isSaturday ) {
                date = date.AddDays(2);
            }

            value = value + 1;
            if (value > endValue)
            {
                return date;
            }

            return Program.AddDays(date, endValue, value);
        }
    }
}
