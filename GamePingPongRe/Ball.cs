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
            public int BallPlayer { get; set; }
        
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
            public void SetBallAtStartPosition()
            {
                BallPositionX = Console.WindowWidth / 2;
                BallPositionY = Console.WindowHeight / 2;
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
                if (BallPositionX == Console.WindowWidth - 1)/* Reset and give oposite direction for P1*/
                {
                    score.PlayerOneScores();
                    SetBallAtStartPosition();
                    BallDirectionRight = false;
                }
                if (BallPositionX == 1)  /* Reset and give oposite direction for P2 */
                {
                    score.PlayerTwoScores();
                    SetBallAtStartPosition();
                    BallDirectionRight = true;
                }
                if (BallPositionX <= 3)
                {
                    if (BallPositionY >= playerOne.PlayerPosition
                        && BallPositionY < playerOne.PlayerPosition + playerOne.PlayerSize)
                    {
                        BallDirectionRight = true;
                    }
                }
                if (BallPositionX >= Console.WindowWidth -3)
                {
                    if (BallPositionY >= playerTwo.PlayerPosition
                        && BallPositionY < playerTwo.PlayerPosition + playerTwo.PlayerSize)
                    {
                        BallDirectionRight = false;
                    }
                }

            }
        }
    }
}
