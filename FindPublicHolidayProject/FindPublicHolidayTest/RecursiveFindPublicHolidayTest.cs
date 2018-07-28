using System;
using Xunit;
using FindPublicHolidayProject;
using System.Collections.Generic;

namespace FindPublicHolidayTestProject
{
    public class RecursiveFindPublicHolidayTest
    {
        [Fact]
        public void Test_FindPublicHolidayByYear_For_2018()
        {
            var result = FindPublicHolidayProject.RecursiveFindPublicHoliday.GetPublicHolidaysDatesByYear(2018, new DateTime(2018, 1, 1), new List<DateTime>());
            Assert.Collection(result,
                type => Assert.Contains("01/01/2018", type.ToString("dd/MM/yyyy")),
                type => Assert.Contains("02/01/2018", type.ToString("dd/MM/yyyy")),
                type => Assert.Contains("07/05/2018", type.ToString("dd/MM/yyyy")),
                type => Assert.Contains("28/05/2018", type.ToString("dd/MM/yyyy")),
                type => Assert.Contains("06/08/2018", type.ToString("dd/MM/yyyy")),
                type => Assert.Contains("30/11/2018", type.ToString("dd/MM/yyyy")),
                type => Assert.Contains("25/12/2018", type.ToString("dd/MM/yyyy")),
                type => Assert.Contains("26/12/2018", type.ToString("dd/MM/yyyy"))
            );
        }

        [Fact]
        public void Test_FindPublicHolidayByYear_For_2019()
        {
            var result = FindPublicHolidayProject.RecursiveFindPublicHoliday.GetPublicHolidaysDatesByYear(2019, new DateTime(2019, 1, 1), new List<DateTime>());
            Assert.Collection(result,
                type => Assert.Contains("01/01/2019", type.ToString("dd/MM/yyyy")),
                type => Assert.Contains("02/01/2019", type.ToString("dd/MM/yyyy")),
                type => Assert.Contains("06/05/2019", type.ToString("dd/MM/yyyy")),
                type => Assert.Contains("27/05/2019", type.ToString("dd/MM/yyyy")),
                type => Assert.Contains("05/08/2019", type.ToString("dd/MM/yyyy")),
                type => Assert.Contains("30/11/2019", type.ToString("dd/MM/yyyy")),
                type => Assert.Contains("25/12/2019", type.ToString("dd/MM/yyyy")),
                type => Assert.Contains("26/12/2019", type.ToString("dd/MM/yyyy"))
            );
        }
    }
}
