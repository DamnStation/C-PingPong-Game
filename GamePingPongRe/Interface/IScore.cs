namespace GamePingPongRe
{
    public interface IScore
    {
        int PlayerOneScore { get; set; }
        int PlayerTwoScore { get; set; }
        string Separator { get; set; }

        void PlayerOneScores();
        void PlayerTwoScores();
    }
}