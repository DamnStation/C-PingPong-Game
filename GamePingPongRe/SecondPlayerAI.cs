using System;
using System.Collections.Generic;
using System.Text;

namespace GamePingPongRe
{
    partial class PingPong
    {
        class SecondPlayerAI
        {
            public Ball BallPositionAI { get; set; }
            public Random RandAI;
            public Player Player { get; set; }

            public SecondPlayerAI(Ball aBallPositionAI,Random aRandAI, Player aPlayer)
            {
                this.BallPositionAI = aBallPositionAI;
                this.RandAI = aRandAI;
                this.Player = aPlayer;
            }
            

            public void MoveSecondAI()
            {
                int randomNumber = RandAI.Next(0, 101);
                if (randomNumber <= 70)
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
        }
    }
}
