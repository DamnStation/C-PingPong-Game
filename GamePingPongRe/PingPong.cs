﻿using System;

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
        public static void PrintAtTheMidle(string aTextSize)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - aTextSize.Length /2 , Console.WindowHeight / 2);
            Console.Write(aTextSize);
        }
        public static void PrintHint(string aHint)
        {
            Console.SetCursorPosition(Console.WindowWidth - aHint.Length - 2, 1);
            Console.Write(aHint);
        }
        static void Main(string[] args)
        {
            var playerOne = new Player(Console.WindowHeight / 2 / 2, 1, 1, "|]");
            var playerTwo = new Player(10, Console.WindowWidth - 2, Console.WindowHeight / 2, "[|");
            var score = new Score(0, "-", 0);
            var ball = new Ball("@", Console.WindowWidth / 2, Console.WindowHeight / 2, false, false, score, playerOne, playerTwo);
            var randAI = new Random();
            var playerAI = new SecondPlayerAI(ball, randAI, playerTwo);
            
            Console.Title = "Ping Pong";
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Loading...");
            PrintAtTheMidle(Setup.wellcome);
            playerAI.NiceA();

            
            while (true)
            {
                Console.Clear();
                PrintHint(Setup.hintPlayerOneSkin);
                PrintAtTheMidle(Setup.pickPlayerOneSymbols);
                playerOne.PlayerSkin = Console.ReadLine();
                if (playerOne.PlayerSkin.Length == 1 || playerOne.PlayerSkin.Length == 2)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    PrintHint(Setup.hintPlayerOneSkin);
                    PrintAtTheMidle(Setup.pickPlayerOneSymbols);
                    playerOne.PlayerSkin = Console.ReadLine();
                }
            }
            
            while (true)
            {
                Console.Clear();
                PrintHint(Setup.hintSkin);
                PrintAtTheMidle(Setup.pickPlayerSymbols);
                playerTwo.PlayerSkin = Console.ReadLine();
                if (playerTwo.PlayerSkin.Length == 1 || playerTwo.PlayerSkin.Length == 2)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    PrintHint(Setup.hintSkin);
                    PrintAtTheMidle(Setup.pickPlayerSymbols);
                    playerTwo.PlayerSkin = Console.ReadLine();
                }
            }
           
            while (true)
            {
                Console.Clear();
                Console.Write(Setup.minMaxSize);
                PrintHint(Setup.hintPlayerSize);
                PrintAtTheMidle(Setup.pickPlayerOneSize);
                Setup.parseFieldString = Console.ReadLine();
                int.TryParse(Setup.parseFieldString, out Setup.parseFieldInt);
                playerOne.PlayerSize = Setup.parseFieldInt;

                if (playerOne.PlayerSize > 1 && playerOne.PlayerSize < 16)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write(Setup.minMaxSize);
                    PrintHint(Setup.hintPlayerSize);
                    PrintAtTheMidle(Setup.pickPlayerOneSize);
                    Setup.parseFieldString = Console.ReadLine();
                    int.TryParse(Setup.parseFieldString, out Setup.parseFieldInt);
                    playerOne.PlayerSize = Setup.parseFieldInt;
                }
            }
            
            while (true)
            {
                Console.Clear();
                Console.Write(Setup.minMaxSize);
                PrintHint(Setup.hintPlayerSize);
                PrintAtTheMidle(Setup.pickPlayerTwoSize);
                Setup.parseFieldString = Console.ReadLine();
                int.TryParse(Setup.parseFieldString, out Setup.parseFieldInt);
                playerTwo.PlayerSize = Setup.parseFieldInt;

                if (playerTwo.PlayerSize > 1 && playerTwo.PlayerSize < 16)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write(Setup.minMaxSize);
                    PrintHint(Setup.hintPlayerSize);
                    PrintAtTheMidle(Setup.pickPlayerTwoSize);
                    Setup.parseFieldString = Console.ReadLine();
                    int.TryParse(Setup.parseFieldString, out Setup.parseFieldInt);
                    playerTwo.PlayerSize = Setup.parseFieldInt;
                }
            }

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
