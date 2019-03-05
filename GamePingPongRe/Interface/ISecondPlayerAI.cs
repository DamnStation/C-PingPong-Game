namespace GamePingPongRe
{
    interface ISecondPlayerAI
    {
        PingPong.Ball BallPositionAI { get; set; }
        PingPong.Player Player { get; set; }

        void MoveSecondAI();
    }
}