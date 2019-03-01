using System;
using System.Collections.Generic;
using System.Text;
using GamePingPongRe;

namespace GamePingPongRe
{
    partial class PingPong
    {
        public class Player : IPlayer
        {
            private int playerSize;
            private string playerSkin;
            private int playerPosition;
            private int playerPositionX;
            private int playerPositionY;

            public int PlayerSize { get => playerSize; set => playerSize = value; }
            public string PlayerSkin { get => playerSkin; set => playerSkin = value; }
            public int PlayerPosition { get => playerPosition; set => playerPosition = value; }
            public int PlayerPositionX { get => playerPositionX; set => playerPositionX = value; }
            public int PlayerPositionY { get => playerPositionY; set => playerPositionY = value; }

            public Player(int aPlayerSize, int aPlayerPosition, int aPlayerPositionX, int aPlayerPositionY, string aPlayerSkin)
            {
                PlayerSize = aPlayerSize;
                PlayerPositionX = aPlayerPositionX;
                PlayerPositionY = aPlayerPositionY;
                PlayerPosition = aPlayerPosition;
                PlayerSkin = aPlayerSkin;
            }

            public void DrawPlayer()
            {
                for (int y = PlayerPosition; y < PlayerPosition + PlayerSize; y++)
                {
                    Methods.PrintAtPosition(PlayerPositionX, y, PlayerSkin);
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
