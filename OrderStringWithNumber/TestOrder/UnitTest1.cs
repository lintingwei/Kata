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
            TestWithWordsAndAnswer(words, answer);
        }
        [TestCase("w1", "w1")]
        public void TestOneWords(string words, string answer)
        {
            TestWithWordsAndAnswer(words, answer);
        }
        [TestCase("is2 Thi1s", "Thi1s is2")]
        public void TestTwoWords(string words, string answer)
        {
            TestWithWordsAndAnswer(words, answer);
        }
        [TestCase("is2 Thi1s T4est 3a", "Thi1s is2 3a T4est")]
        public void TestFourWords(string words, string answer)
        {
            TestWithWordsAndAnswer(words, answer);
        }

        private void TestWithWordsAndAnswer(string words, string answer)
        {
            OrderString orderString = new OrderString();
            Assert.AreEqual(orderString.Order(words), answer);
        }
    }
}