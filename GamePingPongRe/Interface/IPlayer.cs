namespace GamePingPongRe
{
    public interface IPlayer
    {
        int PlayerSize { get; set; }
        string PlayerSkin { get; set; }
        int PlayerPosition { get; set; }
        int PlayerPositionX { get; set; }
        int PlayerPositionY { get; set; }
    }
}