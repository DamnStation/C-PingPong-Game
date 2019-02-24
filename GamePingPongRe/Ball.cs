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
            public bool ballPlayer = false;

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
                    //ballDirectionRight = true;
                }
                else
                {
                    ballPositionX--;
                    //ballDirectionRight = false; 
                }
                if (ballPositionY == Console.WindowHeight -1)
                {
                    ballDirectionUp = true;
                }
                // Score
                if (ballPositionX == Console.WindowWidth -1)
                {
                    Score.playerOneScore++;
                    DrawBall();
                }
                if (ballPositionX == 0)
                {
                    Score.playerTwoScore++;
                }
                //if (ballPositionX == playerPosition + playerSize) 
                //{
                //    ballDirectionRight = !ballDirectionRight;
                //}

                if (ballPositionX == Console.WindowWidth /* Reset and give oposite direction for P1*/)
                {
                    ballPlayer = true;
                    ballPositionX = Console.WindowWidth / 2;
                    ballPositionY = Console.WindowHeight / 2;
                    ballDirectionRight = false;
                    
                }
                if (ballPositionX == Console.WindowLeft  /* Reset and give oposite direction for P2 */)
                {
                    ballPlayer = true;
                    ballPositionX = Console.WindowWidth / 2;
                    ballPositionY = Console.WindowHeight / 2;
                    ballDirectionRight = true;
                   
                }


            }
        }
    }
}
