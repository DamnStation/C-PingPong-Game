using System;
using System.IO;

namespace GamePingPongRe
{
    partial class PingPong
    {

        public static void GetRidOfBuffer()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
        }

        public static void PrintAtPosition(int x, int y, string Skin)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Skin);
        }

        static void Main(string[] args)
        {
            var playerOne = new Player(5, Console.WindowHeight / 2 /2, 1, 1, "|]");

            var playerTwo = new Player(5, 10, Console.WindowWidth -2, Console.WindowHeight /2, "[|");

            var score = new Score(0, "-", 0);

            var ball = new Ball("@", Console.WindowWidth / 2 , Console.WindowHeight / 2,false,false,score,playerOne,playerTwo);
            var randAI = new Random();
            var playerAI = new SecondPlayerAI(ball,randAI,playerTwo);
          

            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            
            while (true)
            {

                GetRidOfBuffer();
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.W)
                    {
                        playerOne.MovePlayerUp();

                    }
                    if (keyInfo.Key == ConsoleKey.S)
                    {
                        playerOne.MovePlayerDown();
                    }
                }
               
               

                ball.MoveBall();
                playerOne.DrawPlayer();
                playerTwo.DrawPlayer();
                ball.DrawBall();
                playerAI.MoveSecondAI();
                
                Console.SetCursorPosition(Console.WindowWidth / 2, 1); Console.Write("{0}{1}{2}",score.PlayerOneScore, score.Separator, score.PlayerTwoScore);
                System.Threading.Thread.Sleep(60);
                Console.Clear();
                
            }
            
        }

        
    }
}
