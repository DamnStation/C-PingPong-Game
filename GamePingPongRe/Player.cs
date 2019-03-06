using System;

namespace GamePingPongRe
{
    partial class PingPong
    {
        public class Player : IPlayer
        {
            public int PlayerSize { get; set; }
            public string PlayerSkin { get; set; }
            public int PlayerPosition { get; set; }
            public int PlayerPositionX { get; set; }
            public int PlayerPositionY { get; set; }

            public Player(/*int aPlayerSize,*/ int aPlayerPosition, int aPlayerPositionX, int aPlayerPositionY, string aPlayerSkin)
            {
               // PlayerSize = aPlayerSize;
                PlayerPositionX = aPlayerPositionX;
                PlayerPositionY = aPlayerPositionY;
                PlayerPosition = aPlayerPosition;
                PlayerSkin = aPlayerSkin;
            }

            public void DrawPlayer()
            {
                for (int y = PlayerPosition; y < PlayerPosition + PlayerSize; y++)
                {
                    PrintAtPosition(PlayerPositionX, y, PlayerSkin);
                }
            }

            public void MovePlayerUp()
            {
                if (PlayerPosition > 0)
                {
                    PlayerPosition--;
                }
            }

            public void MovePlayerDown()
            {
                if (PlayerPosition < Console.WindowHeight - PlayerSize)
                {
                    PlayerPosition++;
                }
            }
        }
    }
}
