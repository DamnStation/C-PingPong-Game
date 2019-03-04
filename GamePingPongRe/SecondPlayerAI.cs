using System;
using System.Threading;

namespace GamePingPongRe
{
    partial class PingPong
    {
        class SecondPlayerAI
        {
            public Ball BallPositionAI { get; set; }
            public Random RandAI;
            public Player Player { get; set; }
            public int Difficulty { get; set; }
            public SecondPlayerAI(Ball aBallPositionAI,Random aRandAI, Player aPlayer)
            {
                this.BallPositionAI = aBallPositionAI;
                this.RandAI = aRandAI;
                this.Player = aPlayer;
            }
            public void MoveSecondAI()
            {
                int randomNumber = RandAI.Next(0, 101);
                if (randomNumber <= Difficulty)
                {
                    if (BallPositionAI.BallDirectionUp == true)
                    {
                        Player.MovePlayerUp();
                    }
                    else
                    {
                        Player.MovePlayerDown();
                    }
                }
            }
            public void NiceA()
            {
                Console.Beep(300, 500);
                Thread.Sleep(50);
                Console.Beep(300, 500);
                Thread.Sleep(50);
                Console.Beep(300, 500);
                Thread.Sleep(50);
                Console.Beep(250, 500);
                Thread.Sleep(50);
                Console.Beep(350, 250);
                Console.Beep(300, 500);
                Thread.Sleep(50);
                Console.Beep(250, 500);
                Thread.Sleep(50);
                Console.Beep(350, 250);
                Console.Beep(300, 500);
                Thread.Sleep(50);
            }
        }
    }
}
