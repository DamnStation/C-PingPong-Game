using System;
using System.Collections.Generic;
using System.Text;

namespace GamePingPongRe
{
    partial class PingPong
    {
        public class Ball
        {
            private string _ballSkin;
            private bool _ballDirectionUp;
            private bool _ballDirectionRight;
            private int _ballPositionX;
            private int _ballPositionY;
            private bool _ballPlayer;

            //TODO Try private var and get set prop for communication with other classes => private int BallPositionX;  
            public string BallSkin { get => _ballSkin; set => _ballSkin = value; }
            public bool BallDirectionUp { get => _ballDirectionUp; set => _ballDirectionUp = value; }
            public bool BallDirectionRight { get => _ballDirectionRight; set => _ballDirectionRight = value; }
            public int BallPositionX { get => _ballPositionX; set => _ballPositionX = value; }
            public int BallPositionY { get => _ballPositionY; set => _ballPositionY = value; }
            public bool BallPlayer { get => _ballPlayer; set => _ballPlayer = value; }
            public Score score { get; set; }
            public Player playerOne { get; set; }
            public Player playerTwo { get; set; }

            public Ball(string aBallSkin, int aBallPositionX, int aBallPositionY, bool aBallDirectionUp, bool aBallDirectionRight, Score aScore, Player aPlayerOne, Player aPlayerTwo)
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
                Methods.PrintAtPosition(BallPositionX, BallPositionY, BallSkin);
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

                if (BallPositionX == playerOne.PlayerPositionX)
                {
                    BallDirectionRight = !BallDirectionRight;
                }


            }
        }
    }
}
