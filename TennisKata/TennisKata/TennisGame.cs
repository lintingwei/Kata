using System;
using System.Collections.Generic;
using System.Text;

namespace TennisKata
{
    public class TennisGame
    {
        public int PlayerAScore { get; set; }
        public int PlayerBScore { get; set; }

        public string GetScore()
        {
            if (IsBothScoreMoreThanTwo())
            {
                return BothScoreMoreThanTwoOutput();
            }
            return BothScorelessThanTwo();
        }

        private string BothScorelessThanTwo()
        {
            if (IsScoreEqual())
                return $"{GetScoreOutput(PlayerAScore)} All";
            return $"{GetScoreOutput(PlayerAScore)} {GetScoreOutput(PlayerBScore)}";
        }

        private string GetScoreOutput(int score)
        {
            switch (score)
            {
                case 0:
                    return "Love";
                case 1:
                    return "Fifteen";
                case 2:
                    return "Thirty";
                case 3:
                    return "Forty";
                default:
                    return string.Empty;
            }
        }

        private string BothScoreMoreThanTwoOutput()
        {
            if (IsScoreDifferenceThanOne())
                return PlayerAScoreMoreThanB() ? "Player A Win" : "Player B Win";
            else if (IsScoreEqual())
                return "Deuce";
            else
                return PlayerAScoreMoreThanB() ? "Player A Adv" : "Player B Adv";
        }

        private bool IsScoreEqual()
        {
            return PlayerAScore == PlayerBScore;
        }

        private bool PlayerAScoreMoreThanB()
        {
            return PlayerAScore > PlayerBScore;
        }

        private bool IsScoreDifferenceThanOne()
        {
            return Math.Abs(PlayerAScore - PlayerBScore) > 1;
        }

        private bool IsBothScoreMoreThanTwo()
        {
            return IsPlayerAScoreMoreThanTwo() && IsPlayerBScoreMoreThanTwo();
        }

        private bool IsPlayerBScoreMoreThanTwo()
        {
            return PlayerBScore > 2;
        }

        private bool IsPlayerAScoreMoreThanTwo()
        {
            return PlayerAScore > 2;
        }
    }
}
