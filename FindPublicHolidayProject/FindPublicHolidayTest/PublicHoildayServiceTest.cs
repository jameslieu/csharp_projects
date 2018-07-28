using System;
using System.Collections.Generic;
using System.Text;
using FindPublicHolidayProject;
using Xunit;

namespace FindPublicHolidayTestProject
{
    public class PublicHolidayServiceTest
    {
        [Theory]
        [InlineData(2018, 01, 01)]
        [InlineData(2018, 01, 02)]
        [InlineData(2018, 05, 07)]
        [InlineData(2018, 05, 28)]
        [InlineData(2018, 08, 06)]
        [InlineData(2018, 11, 30)]
        [InlineData(2018, 12, 25)]
        [InlineData(2018, 12, 26)]
        public void Test_IsPublicHoliday_For_2018(int year, int month, int day)
        {
            var result = FindPublicHolidayProject.PublicHolidayService.IsPublicHoliday(new DateTime(year, month, day));
            Assert.True(result);

        }

        [Theory]
        [InlineData(2019, 01, 01)]
        [InlineData(2019, 01, 02)]
        [InlineData(2019, 05, 06)]
        [InlineData(2019, 05, 27)]
        [InlineData(2019, 08, 05)]
        [InlineData(2019, 11, 30)]
        [InlineData(2019, 12, 25)]
        [InlineData(2019, 12, 26)]
        public void Test_IsPublicHoliday_For_2019(int year, int month, int day)
        {
            var result = FindPublicHolidayProject.PublicHolidayService.IsPublicHoliday(new DateTime(year, month, day));
            Assert.True(result);

        }

        [Theory]
        [InlineData(2019, 01, 03)]
        [InlineData(2019, 01, 04)]
        [InlineData(2019, 05, 05)]
        [InlineData(2019, 05, 26)]
        [InlineData(2019, 08, 04)]
        [InlineData(2019, 11, 29)]
        [InlineData(2019, 12, 24)]
        [InlineData(2019, 12, 27)]
        public void Test_Is_Not_A_PublicHoliday(int year, int month, int day)
        {
            var result = FindPublicHolidayProject.PublicHolidayService.IsPublicHoliday(new DateTime(year, month, day));
            Assert.False(result);
        }
    }
}
