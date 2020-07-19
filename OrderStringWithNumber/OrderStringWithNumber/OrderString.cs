using System;
using System.Collections.Generic;
using System.Text;

namespace OrderStringWithNumber
{
    public class OrderString
    {
        public string Order(string words)
        {
            if (string.IsNullOrEmpty(words))
            {
                return string.Empty;
            }

            string[] target = words.Split(' ');
            string[] sorted = new string[target.Length];

            Sorting(target, sorted);

            return GenerateAnswer(sorted);
        }

        private void Sorting(string[] target, string[] sorted)
        {
            foreach (string targetString in target)
            {
                sorted[GetPositionIndex(targetString)] = targetString;
            }
        }

        private string GenerateAnswer(string[] sorted)
        {
            string answer = string.Empty;
            foreach (string word in sorted)
            {
                answer = $"{answer} {word}";
            }

            return answer.Trim();
        }

        private int GetPositionIndex(string targetString)
        {
            char[] singleWords = targetString.ToCharArray();
            foreach (char word in singleWords)
            {
                if (int.TryParse(word.ToString(), out int number))
                {
                    return number - 1;
                }
            }

            return 0;
        }
    }
}
