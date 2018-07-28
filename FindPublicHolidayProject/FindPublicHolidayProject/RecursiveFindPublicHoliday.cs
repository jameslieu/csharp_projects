using System;
using System.Collections.Generic;

namespace FindPublicHolidayProject
{
    public class RecursiveFindPublicHoliday
    {
        public static List<DateTime> GetPublicHolidaysDatesByYear(Int32 year,  DateTime date, List<DateTime> list)
        {
            if (PublicHolidayService.IsPublicHoliday(date))
            {
                list.Add(date);
            }

            date = date.AddDays(1);

            if (date.Year == year)
            {
                return RecursiveFindPublicHoliday.GetPublicHolidaysDatesByYear(year, date, list);
            }
            else
            {
                return list;

            }
        }
    }
}
