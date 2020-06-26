using System;

namespace TennisKata
{
    class Program
    {
        static void Main(string[] args)
        {
            TennisGame tennisGame = new TennisGame()
            {
                PlayerAScore = 5,
                PlayerBScore = 3
            };

            string result = tennisGame.GetScore();
            Console.WriteLine(result);

        }
    }
}
