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
            var result = GetScore(0, 0);

            ShouldEqual(_tennis.LoveAll, result);
        }

        private string GetScore(int score1, int score2)
        {
            var result = _tennis.GetScore(score1, score2);
            return result;
        }

        [Test]
        public void Test_FifteenLove()
        {
            var result = GetScore(1, 0);

            ShouldEqual(_tennis.FifteenLove, result);
        }

        private void ShouldEqual(string tennisFifteenLove, string result)
        {
            Assert.AreEqual(tennisFifteenLove, result);
        }
    }
}