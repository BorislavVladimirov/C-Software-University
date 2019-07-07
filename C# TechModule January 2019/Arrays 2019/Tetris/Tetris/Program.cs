using System;

namespace Tetris
{
    class Program
    {
        static int TetrisRows = 20;
        static int TetrisCols = 10;
        static int InfoCols = 10;
        static int ConsoleRows = 1 + TetrisRows + 1;
        static int ConsoleCols = 1 + TetrisCols + 1 + InfoCols + 1;

        static void Main(string[] args)
        {
            int a = 1;
            Console.Title = "Tetris v1.0";
            Console.WindowHeight = ConsoleRows;
            Console.WindowWidth = ConsoleCols;
            Console.BufferHeight = ConsoleRows;
            Console.BufferWidth = ConsoleCols;
        }

        static void DrawBorder()
        {
            string line = "";
        }

        static void Write(string text, int row, int cow, ConsoleColor color = ConsoleColor)
        {
            Console.ForegroundColor = color;
        }
    }
}
