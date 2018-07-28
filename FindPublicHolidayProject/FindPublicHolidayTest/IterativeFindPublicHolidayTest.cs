using System;
using Xunit;
using FindPublicHolidayProject;
using System.Collections.Generic;

namespace FindPublicHolidayTestProject
{
    public class IterativeFindPublicHolidayTest
    {
        [Fact]
        public void Test_FindPublicHolidayByYear_For_2018()
        {
            var result = FindPublicHolidayProject.IterativeFindPublicHoliday.GetPublicHolidaysDatesByYear(2018);
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
            var result = FindPublicHolidayProject.IterativeFindPublicHoliday.GetPublicHolidaysDatesByYear(2019);
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
