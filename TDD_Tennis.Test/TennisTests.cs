using NUnit.Framework;

namespace TDD_Tennis.Test
{
    public class TennisTest
    {
        private Tennis _tennis;

        [SetUp]
        public void Setup()
        {
            _tennis = new Tennis();
        }

        [Test]
        public void Test_LoveAll()
        {
            var result = _tennis.GetScore(0, 0);

            Assert.AreEqual(_tennis.LoveAll, result);
        }

        [Test]
        public void Test_FifteenLove()
        {
            var result = _tennis.GetScore(1, 0);

            Assert.AreEqual(_tennis.FifteenLove, result);
        }
    }
}