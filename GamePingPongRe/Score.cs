using System;

namespace GamePingPongRe
{
    partial class PingPong
    {
        public class Score
        {
            public string Separator { get; set; }
            public int PlayerTwoScore { get; set; }
            public int PlayerOneScore { get;set; }

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
