using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlienShooter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            int projectileX = 0;
            int projectileY = 0;
            bool isShotMade = false;

            int screenWidth = 30;
            int screenHeight = 20;
            Console.SetWindowSize(screenWidth, screenHeight);
            Console.SetBufferSize(screenWidth, screenHeight);

            int playerX = screenWidth / 2;
            int playerY = screenHeight - 1;
            Console.SetCursorPosition(playerX, playerY);
            Console.Write("^");

            var pressedKey = Console.ReadKey();

            if (pressedKey.Key == ConsoleKey.RightArrow)
            {
                playerX++; //playerX = playerX + 1
            }
            else if (pressedKey.Key == ConsoleKey.LeftArrow)
            {
                playerX--; //playerX = playerX - 1
            }
            else if (pressedKey.Key == ConsoleKey.Spacebar)
            {
                projectileX = playerX;
                projectileY = playerY - 1;
                isShotMade = true;
            }

            Console.Clear();

            if (isShotMade == true)
            {
                Console.SetCursorPosition(projectileX, projectileY);
                Console.Write("*");
            }

            Console.SetCursorPosition(playerX, playerY);
            Console.Write("^");
            Console.ReadLine();

        }
    }
}