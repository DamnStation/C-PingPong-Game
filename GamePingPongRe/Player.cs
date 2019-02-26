using System;
using System.Collections.Generic;
using System.Text;
using GamePingPongRe;

namespace GamePingPongRe
{
    partial class PingPong
    {
        public class Player
        {
            public int playerSize;
            public string playerSkin;
            public int playerPosition;
            public int playerPositionX;
            public int playerPositionY;

            public Player(int aPlayerSize, int aPlayerPosition, int aPlayerPositionX, int aPlayerPositionY, string aPlayerSkin)
            {
                playerSize = aPlayerSize;
                playerPositionX = aPlayerPositionX;
                playerPositionY = aPlayerPositionY;
                playerPosition = aPlayerPosition;
                playerSkin = aPlayerSkin;
            }

            public void DrawPlayer()
            {
                for (int y = playerPosition; y < playerPosition + playerSize; y++)
                {
                    PrintAtPosition(playerPositionX, y, playerSkin);
                }
            }

            public void MovePlayerUp()
            {
                if (playerPosition > 0)
                {
                    playerPosition--;
                }
            }

            public void MovePlayerDown()
            {
                if (playerPosition < Console.WindowHeight - playerSize)
                {
                    playerPosition++;
                }
            }
        }
    }
}
