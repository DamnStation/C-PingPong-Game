using System;
using System.Collections.Generic;
using System.Text;

namespace GamePingPongRe
{
    partial class PingPong
    {
        public class Ball
        {
            public int BallPositionX { get; set; }
            public int BallPositionY { get; set; }
            public string BallSkin { get; set; }
            public bool BallDirectionUp { get; set; }
            public bool BallDirectionRight { get; set; }
            public bool BallPlayer { get; set; }
            public Score score { get; set; }
            public Player playerOne { get; set; }
            public Player playerTwo { get; set; }
            

            public Ball(
                string aBallSkin,
                int aBallPositionX, int aBallPositionY,
                bool aBallDirectionUp, bool aBallDirectionRight,
                Score aScore, Player aPlayerOne, Player aPlayerTwo)
            {
                BallSkin = aBallSkin;
                // ballPosition = aBallPosition;
                BallPositionX = aBallPositionX;
                BallPositionY = aBallPositionY;
                BallDirectionUp = aBallDirectionUp;
                BallDirectionRight = aBallDirectionRight;
                score = aScore;
                playerOne = aPlayerOne;
                playerTwo = aPlayerTwo;
               
            }

            public void DrawBall()
            {
                PrintAtPosition(BallPositionX, BallPositionY, BallSkin);
            }

            public void MoveBall()
            {
                if (BallPositionY == 0)
                {
                    BallDirectionUp = false;
                }
                if (BallDirectionUp)
                {
                    BallPositionY--;
                }
                else
                {
                    BallPositionY++;
                }
                if (BallDirectionRight)
                {
                    BallPositionX++;
                    //ballDirectionRight = true;
                }
                else
                {
                    BallPositionX--;
                    //ballDirectionRight = false; 
                }
                if (BallPositionY == Console.WindowHeight - 1)
                {
                    BallDirectionUp = true;
                }
                // Score
                if (BallPositionX == Console.WindowWidth - 1)
                {
                    score.PlayerOneScores();
                    DrawBall();
                }
                if (BallPositionX == 0)
                {
                    score.PlayerTwoScores();
                }

                if (BallPositionX == Console.WindowWidth /* Reset and give oposite direction for P1*/)
                {
                    // ballPlayer = true;
                    BallPositionX = Console.WindowWidth / 2;
                    BallPositionY = Console.WindowHeight / 2;
                    BallDirectionRight = false;

                }
                if (BallPositionX == Console.WindowLeft  /* Reset and give oposite direction for P2 */)
                {
                    // ballPlayer = true;
                    BallPositionX = Console.WindowWidth / 2;
                    BallPositionY = Console.WindowHeight / 2;
                    BallDirectionRight = true;

                }

                if (this.BallPositionX == playerOne.PlayerPositionX)
                {
                    BallDirectionRight = !BallDirectionRight;
                }


            }
        }
    }
}
