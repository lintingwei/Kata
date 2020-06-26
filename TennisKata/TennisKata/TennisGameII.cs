using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TennisKata
{
    public class TennisGameII
    {
        private int PlayerAScore { get; }
        private int PlayerBScore { get; }

        public TennisGameII(int playerAScore, int playerBScore)
        {
            PlayerAScore = playerAScore;
            PlayerBScore = playerBScore;
        }

        public string GetScore()
        {
            if (IsGameSet())
            {
                return $"{GetPlayerNameWithHigherScore()} Win";
            }

            if (IsAdvantage())
            {
                return $"{GetPlayerNameWithHigherScore()} Adv";
            }

            if (IsDeuce())
            {
                return "Deuce";
            }

            if (IsScoreEqual())
            {
                return $"{GetScoreOutput(PlayerAScore)} All";
            }

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

        private bool IsDeuce()
        {
            return IsOneScoreMoreThanTwo() && IsScoreEqual();
        }

        private bool IsOneScoreMoreThanTwo()
        {
            return PlayerAScore > 2 || PlayerBScore > 2;
        }

        private bool IsScoreEqual()
        {
            return PlayerAScore == PlayerBScore;
        }

        private bool IsAdvantage()
        {
            return IsOneScoreMoreThanThree() && Math.Abs(PlayerAScore - PlayerBScore) == 1;
        }

        private string GetPlayerNameWithHigherScore()
        {
            return PlayerAScore > PlayerBScore ? "Player A" : "Player B";
        }

        private bool IsGameSet()
        {
            return IsOneScoreMoreThanThree() && TwoScoreDifferenceTwo();
        }

        private bool TwoScoreDifferenceTwo()
        {
            return Math.Abs(PlayerAScore - PlayerBScore) > 1;
        }

        private bool IsOneScoreMoreThanThree()
        {
            return PlayerAScore > 3 || PlayerBScore > 3;
        }
    }
}
