using NUnit.Framework;

namespace MultiplesOf3Or5.Tests
{
    public class Tests
    {
        [Test]
        public void Test_GetMultipleOf3Or5()
        {
            var actual = MultiplesOf3Or5.GetMultiplesOf3Or5(10);
            Assert.That(actual, Is.EqualTo(23));
        }
    }
}