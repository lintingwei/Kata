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

            return GenerateSortedString(sorted);
        }

        private void Sorting(string[] target, string[] sorted)
        {
            foreach (string targetString in target)
            {
                sorted[GetPositionIndex(targetString)] = targetString;
            }
        }

        private string GenerateSortedString(string[] sorted)
        {
            string sortedString = string.Empty;
            foreach (string word in sorted)
            {
                sortedString = $"{sortedString} {word}";
            }

            return sortedString.Trim();
        }

        private int GetPositionIndex(string targetString)
        {
            char[] singleWords = targetString.ToCharArray();
            foreach (char singleWord in singleWords)
            {
                if (int.TryParse(singleWord.ToString(), out int numberInSingleWords))
                {
                    return numberInSingleWords - 1;
                }
            }

            return 0;
        }
    }
}
