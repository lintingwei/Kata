using NUnit.Framework;
using OrderStringNumber;

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
            OrderKata orderKata = new OrderKata();
            
            Assert.AreEqual(orderKata.Order(words), answer);
        }
    }
}