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

            return words;
        }
    }
}
