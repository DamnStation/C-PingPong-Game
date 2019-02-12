using System;
using System.Collections.Generic;
using System.Text;

namespace GamePingPongRe
{
    partial class PingPong
    {
        public class Ball
        {
            public string ballSkin { get; set; }
            public int ballPosition { get; set; }

            public int ballPositionX { get; set; }
            public int ballPositionY { get; set; }

            public Ball(string aBallSkin, int aBallPositionX, int aBallPositionY)
            {
                ballSkin = aBallSkin;
               // ballPosition = aBallPosition;
                ballPositionX = aBallPositionX;
                ballPositionY = aBallPositionY;
            }

            public void DrawBall()
            {
                PrintAtPosition(ballPositionX , ballPositionY, ballSkin);
            }

            public void MoveBallUpRight()
            {
                ballPositionY--;
                ballPositionX++;
            }
            public void MoveBallDownLeft()
            {
                ballPositionY++;
                ballPositionX--;
            }
        }
    }
}
