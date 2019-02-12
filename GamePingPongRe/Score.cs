namespace GamePingPongRe
{
    partial class PingPong
    {
        public class Score
        {
            public int playerOneScore = 10;
            public string separator = "-";
            public int playerTwoScore = 10;
            
            

            public Score(int aPlayerOneScore,string aSeparator, int aPlayerTwoScore)
            {
                playerOneScore = aPlayerOneScore;
                separator = aSeparator;
                playerTwoScore = aPlayerTwoScore;

            }

            public void PlayerOneScores()
            {
                playerOneScore++;
            }

            public void PlayerTwoScore()
            {
                playerTwoScore++;
            }
        }
    }
}
