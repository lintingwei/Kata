using NUnit.Framework;

namespace TDD_Tennis.Test
{
    public class TennisTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_LoveAll()
        {
            var tennis = new Tennis();

            var result = tennis.GetScore(0,0);

            Assert.AreEqual("Love All", result);
        }

    }
}