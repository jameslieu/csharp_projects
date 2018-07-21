using System;
using Xunit;

namespace CalculateBusinessDaysTests
{
    public class CalculateBusinessDaysTest
    {
        [Fact]
        public void CalculateDaysTest_addNegativeDays()
        {
            int numberOfDays = -1;

            // 2/1/2018 is on a Tuesday
            DateTime date = new DateTime(2018, 1, 2);
            var result = CalculateBusinessDays.Program.AddDateInBusinessdays(date, numberOfDays);

            Assert.Equal(new DateTime(2018, 1, 2).ToString("dd/MM/yyyy"), result.ToString("dd/MM/yyyy"));
        }

        [Fact]
        public void CalculateDaysTest_addZeroDay()
        {
            int numberOfDays = 0;

            // 2/1/2018 is on a Tuesday
            DateTime date = new DateTime(2018, 1, 2);
            var result = CalculateBusinessDays.Program.AddDateInBusinessdays(date, numberOfDays);

            Assert.Equal(new DateTime(2018, 1, 2).ToString("dd/MM/yyyy"), result.ToString("dd/MM/yyyy"));
        }

        [Fact]
        public void CalculateDaysTest_addOneDay()
        {
            int numberOfDays = 1;

            // 2/1/2018 is on a Tuesday
            DateTime date = new DateTime(2018, 1, 2);
            var result = CalculateBusinessDays.Program.AddDateInBusinessdays(date, numberOfDays);

            Assert.Equal(new DateTime(2018, 1, 3).ToString("dd/MM/yyyy"), result.ToString("dd/MM/yyyy"));
        }

        [Fact]
        public void CalculateDaysTest_addTenDays()
        {
            int numberOfDays = 10;

            // 2/1/2018 is on a Thursday
            DateTime date = new DateTime(2018, 2, 1);
            var result = CalculateBusinessDays.Program.AddDateInBusinessdays(date, numberOfDays);

            Assert.Equal(new DateTime(2018, 2, 15).ToString("dd/MM/yyyy"), result.ToString("dd/MM/yyyy"));
        }


        [Fact]
        public void CalculateDaysTest_TestSaturdayIsIgnored()
        {
            int numberOfDays = 1;

            // 5/1/2018 is on a Friday
            DateTime date = new DateTime(2018, 1, 5);
            var result = CalculateBusinessDays.Program.AddDateInBusinessdays(date, numberOfDays);

            // The next working day is Monday 8th January 2018
            Assert.Equal(new DateTime(2018, 1, 8).ToString("dd/MM/yyyy"), result.ToString("dd/MM/yyyy"));
        }

        [Fact]
        public void CalculateDaysTest_TestSundayIsIgnored()
        {
            int numberOfDays = 1;

            // 6/1/2018 is on a Saturday
            DateTime date = new DateTime(2018, 1, 6);
            var result = CalculateBusinessDays.Program.AddDateInBusinessdays(date, numberOfDays);

            // The next working day is Monday 8th January 2018
            Assert.Equal(new DateTime(2018, 1, 8).ToString("dd/MM/yyyy"), result.ToString("dd/MM/yyyy"));
        }

        [Fact]
        public void CalculateDaysTest_TestPublicHolidayIsIgnored()
        {
            int numberOfDays = 1;

            // 25/12/2018 is on a Tuesday
            DateTime date = new DateTime(2018, 12, 25);
            var result = CalculateBusinessDays.Program.AddDateInBusinessdays(date, numberOfDays);

            // The next working day is Thursday 27th December 2018
            Assert.Equal(new DateTime(2018, 12, 27).ToString("dd/MM/yyyy"), result.ToString("dd/MM/yyyy"));
        }
    }
}
