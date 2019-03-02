using System;

namespace GamePingPongRe
{
    partial class PingPong
    {
        public class Score
        {
            private int playerOneScore;
            private string separator;
            private int playerTwoScore;

            public int PlayerOneScore { get => playerOneScore; set => playerOneScore = value; }
            public string Separator { get => separator; set => separator = value; }
            public int PlayerTwoScore { get => playerTwoScore; set => playerTwoScore = value; }

            public Score(int aPlayerOneScore, string aSeparator, int aPlayerTwoScore)
            {
                this.PlayerOneScore = aPlayerOneScore;
                this.Separator = aSeparator;
                this.PlayerTwoScore = aPlayerTwoScore;
            }

            public void PlayerOneScores()
            {
                PlayerOneScore++;
            }

            public void PlayerTwoScores()
            {
                PlayerTwoScore++;
            }
        }
    }
}
