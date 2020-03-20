using System;
using System.Collections.Generic;
using System.Linq;

namespace String_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static string AverageString(string str)
        {
            if (string.IsNullOrEmpty(str))
                return "n/a";
            str = str.Replace(",", string.Empty);
            string[] targetNumbers = str.Split(' ');
            int result = 0;
            var dic = GetNumberDictionary();
            foreach (var number in targetNumbers)
            {
                if (dic.TryGetValue(number, out int num))
                {
                    result += num;
                }
                else
                {
                    return "n/a";
                }
            }

            result /= targetNumbers.Length;
            if (result >= 0 && result < 10)
                return dic.FirstOrDefault(x => x.Value == result).Key;
            return "n/a";
        }


        public static Dictionary<string, int> GetNumberDictionary()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            result.Add("zero", 0);
            result.Add("one", 1);
            result.Add("two", 2);
            result.Add("three", 3);
            result.Add("four", 4);
            result.Add("five", 5);
            result.Add("six", 6);
            result.Add("seven", 7);
            result.Add("eight", 8);
            result.Add("nine", 9);
            return result;
        }
    }
}
