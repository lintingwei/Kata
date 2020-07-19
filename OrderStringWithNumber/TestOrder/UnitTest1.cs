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
        [TestCase("w1", "w1")]
        public void TestOneWords(string words, string answer)
        {
            OrderString orderString = new OrderString();
            Assert.AreEqual(orderString.Order(words), answer);
        }
        [TestCase("is2 Thi1s", "Thi1s is2")]
        public void TestTwoWords(string words, string answer)
        {
            OrderString orderString = new OrderString();
            Assert.AreEqual(orderString.Order(words), answer);
        }
    }
}