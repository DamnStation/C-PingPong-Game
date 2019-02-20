namespace GamePingPongRe
{
    partial class PingPong
    {
        public static class Score
        {
            public static int playerOneScore;
            public static string separator;
            public static int playerTwoScore;
            
            //public Score(int aPlayerOneScore,string aSeparator, int aPlayerTwoScore)
            //{
            //    playerOneScore = aPlayerOneScore;
            //    separator = aSeparator;
            //    playerTwoScore = aPlayerTwoScore;
            //}

            public static void PlayerOneScores()
            {
                playerOneScore++;
            }

            public static void PlayerTwoScore()
            {
                playerTwoScore++;
            }
        }
    }
}
