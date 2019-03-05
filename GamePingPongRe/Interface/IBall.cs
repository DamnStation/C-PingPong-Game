namespace GamePingPongRe
{
    public interface IBall
    {
        bool BallDirectionRight { get; set; }
        bool BallDirectionUp { get; set; }
        int BallPositionX { get; set; }
        int BallPositionY { get; set; }
        string BallSkin { get; set; }

        void DrawBall();
        void MoveBall();
        void SetBallAtStartPosition();
    }
}