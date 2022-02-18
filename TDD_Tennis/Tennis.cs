﻿using System;

namespace TDD_Tennis
{
    public class Tennis
    {
        public readonly string FifteenLove = "Fifteen Love";
        public readonly string LoveAll = "Love All";

        public string GetScore(int score1, int score2)
        {
            if (score1 == 1 && score2 == 0)
            {
                return FifteenLove;
            }

            return LoveAll;
        }
    }
}
