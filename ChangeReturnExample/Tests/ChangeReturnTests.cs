using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class ChangeReturnTests
    {
        [TestMethod]
        public void TestGetChange()
        {
            var expected = new List<string>
            {
                "1 pound",
                "1 fifty pence",
                "0 twenty pence",
                "0 ten pence",
                "1 five pence",
                "0 two pence",
                "1 one pence",
            };

            var purchasePrice = 3.44m;
            var moneyPaid = 5.00m;

            List<string> result = ChangeReturnExample.Purchase.ReceiveChange(purchasePrice, moneyPaid);
            CollectionAssert.AreEqual(result, expected);
        }
    }
}
