using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int widgh = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int totalSize = widgh * lenght;
            int piecesLeft = 0;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int pieceTaken = int.Parse(input);

                totalSize = totalSize - pieceTaken;
                piecesLeft = totalSize;

                if (piecesLeft < 0)
                {
                    int diff = Math.Abs(totalSize);
                    Console.WriteLine($"No more cake left! You need {diff} pieces more.");
                    return;
                }

                input = Console.ReadLine(); 
            }
            Console.WriteLine($"{piecesLeft} pieces are left.");
        }
    }
}
