using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseStringTests
{
    [TestClass]
    public class ReverseStringTest
    {
        [TestMethod]
        public void TestReverse()
        {
            string str = "John Doe 1234567890";
            string result = ReverseStringExample.ReverseString.Reverse(str);

            Assert.AreEqual(result, "0987654321 eoD nhoJ");
        }
    }
}
