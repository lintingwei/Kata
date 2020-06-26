using NUnit.Framework;
using TennisKata;

namespace Tests
{
    public class TestTennisGame
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(0, 0, "Love All")]
        [TestCase(1, 0, "Fifteen Love")]
        [TestCase(2, 0, "Thirty Love")]
        [TestCase(3, 0, "Forty Love")]
        [TestCase(0, 1, "Love Fifteen")]
        [TestCase(0, 2, "Love Thirty")]
        [TestCase(0, 3, "Love Forty")]
        [TestCase(1, 1, "Fifteen All")]
        [TestCase(2, 2, "Thirty All")]
        [TestCase(3, 3, "Deuce")]
        [TestCase(4, 4, "Deuce")]
        [TestCase(4, 3, "Player A Adv")]
        [TestCase(5, 3, "Player A Win")]
        [TestCase(3, 4, "Player B Adv")]
        [TestCase(3, 5, "Player B Win")]
        public void TestScore(int playerAScore, int playerBScore, string score)
        {
            TennisGame tennisGame = new TennisGame()
            {
                PlayerAScore = playerAScore,
                PlayerBScore = playerBScore
            };

            Assert.AreEqual(score, tennisGame.GetScore());
        }
        [Test]
        [TestCase(0, 0, "Love All")]
        [TestCase(1, 0, "Fifteen Love")]
        [TestCase(2, 0, "Thirty Love")]
        [TestCase(3, 0, "Forty Love")]
        [TestCase(0, 1, "Love Fifteen")]
        [TestCase(0, 2, "Love Thirty")]
        [TestCase(0, 3, "Love Forty")]
        [TestCase(1, 1, "Fifteen All")]
        [TestCase(2, 2, "Thirty All")]
        [TestCase(3, 3, "Deuce")]
        [TestCase(4, 4, "Deuce")]
        [TestCase(4, 3, "Player A Adv")]
        [TestCase(5, 3, "Player A Win")]
        [TestCase(3, 4, "Player B Adv")]
        [TestCase(3, 5, "Player B Win")]
        public void TestGetScoreII(int playerAScore, int playerBScore, string score)
        {
            TennisGameII tennisGame = new TennisGameII(playerAScore, playerBScore);

            Assert.AreEqual(score, tennisGame.GetScore());
        }
    }
}