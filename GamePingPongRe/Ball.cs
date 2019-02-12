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
            public bool ballDirectionUp { get; set; }
            public bool ballDirectionRight { get; set; }
            public int ballPositionX { get; set; }
            public int ballPositionY { get; set; }

            public Ball(string aBallSkin, int aBallPositionX, int aBallPositionY,bool aBallDirectionUp,bool aBallDirectionRight)
            {
                ballSkin = aBallSkin;
               // ballPosition = aBallPosition;
                ballPositionX = aBallPositionX;
                ballPositionY = aBallPositionY;
                ballDirectionUp = aBallDirectionUp;
                ballDirectionRight = aBallDirectionRight;
            }

            public void DrawBall()
            {
                PrintAtPosition(ballPositionX , ballPositionY, ballSkin);
            }

            public void MoveBall()
            {
                if (ballPositionY == 0)
                {
                    ballDirectionUp = false;
                }
                if (ballDirectionUp)
                {
                    ballPositionY--;
                }
                else
                {
                    ballPositionY++;
                }
                if (ballDirectionRight)
                {
                    ballPositionX++;
                }
                else
                {
                    ballDirectionRight = false;
                }
                if (ballPositionY == Console.WindowHeight -1)
                {
                    ballDirectionUp = true;
                }
            }
        }
    }
}
