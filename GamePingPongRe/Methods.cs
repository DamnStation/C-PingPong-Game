using System;
using System.Collections.Generic;
using System.Text;

namespace GamePingPongRe
{
    public class Methods

    {
        public static void Methods()
        {

        }
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

    }
}
