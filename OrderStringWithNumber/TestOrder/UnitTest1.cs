using NUnit.Framework;
using OrderStringWithNumber;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("", "")]
        public void TestStringEmpty(string words, string answer)
        {
            OrderString orderString = new OrderString();
            Assert.AreEqual(orderString.Order(words), answer);
        }
    }
}