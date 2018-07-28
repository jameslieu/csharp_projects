using System;
using System.Collections.Generic;

namespace FindPublicHolidayProject
{
    public class IterativeFindPublicHoliday
    {
        public static List<DateTime> GetPublicHolidaysDatesByYear(Int32 year)
        {
            List<DateTime> list = new List<DateTime>();
            DateTime date = new DateTime(year, 1, 1);

            while (date.Year == year)
            {
                if (PublicHolidayService.IsPublicHoliday(date))
                {
                    list.Add(date);
                }

                date = date.AddDays(1);
            }

            return list;
        }

    }
}
