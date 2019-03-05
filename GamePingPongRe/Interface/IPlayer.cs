namespace GamePingPongRe
{
    public interface IPlayer
    {
        int PlayerPosition { get; set; }
        int PlayerPositionX { get; set; }
        int PlayerPositionY { get; set; }
        int PlayerSize { get; set; }
        string PlayerSkin { get; set; }

        void DrawPlayer();
        void MovePlayerDown();
        void MovePlayerUp();
    }
}