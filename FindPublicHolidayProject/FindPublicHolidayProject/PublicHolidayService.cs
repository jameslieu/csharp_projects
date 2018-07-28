using System;

namespace FindPublicHolidayProject
{
    public class PublicHolidayService
    {
        public static Boolean IsPublicHoliday(DateTime date)
        {
            String month = date.ToString("MMM");

            if (month == "Jan")
            {
                if (date.Day == 1 || date.Day == 2)
                {
                    return true;
                }
            }

            if (month == "May")
            {
                if (PublicHolidayService.IsFirstMonday(date) || PublicHolidayService.IsLastMonday(date))
                {
                    return true;
                }
            }

            if (month == "Aug")
            {
                if (PublicHolidayService.IsFirstMonday(date))
                {
                    return true;
                }
            }


            if (month == "Nov")
            {
                if (date.Day == 30)
                {
                    return true;
                }
            }

            if (month == "Dec")
            {
                if (date.Day == 25 || date.Day == 26)
                {
                    return true;
                }

                // If Christmas Day is a Sunday there is an additional statutory holiday on 27 December.
                // By Royal Proclamation, if Christmas Day is a Saturday there is a substitute holiday on 28 December.
                // If Boxing Day is a Sunday there is again a statutory holiday on 27 December,

                if (date.Day == 27 && PublicHolidayService.IsMonday(date))
                {
                    return true;
                }

                // If Boxing Day is a Saturday there is a substitute holiday by Royal Proclamation on 28 December.
                if (date.Day == 28 && PublicHolidayService.IsMonday(date))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsMonday(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Monday;
        }

        private static bool IsFirstMonday(DateTime date)
        {
            return PublicHolidayService.IsMonday(date) && date.Day <= 7;
        }

        private static bool IsLastMonday(DateTime date)
        {
            if (!PublicHolidayService.IsMonday(date))
            {
                return false; // it is not monday
            }

            // the next monday is...
            var oneWeekAfter = date.AddDays(7);

            // and is it in same month?, if it is, that means its not last monday
            return oneWeekAfter.Month != date.Month;
        }
    }
}
