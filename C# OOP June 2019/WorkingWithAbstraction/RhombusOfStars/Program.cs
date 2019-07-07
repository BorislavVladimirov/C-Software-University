using System;

namespace RhombusOfStars
{
    public class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                PrintRow(size, i);
            }

            for (int i = size - 1; i >= 1; i--)
            {
                PrintRow(size, i);
            }
        }

        private static void PrintRow(int figureSize, int starCount)
        {
            for (int i = 0; i < figureSize - starCount; i++)
            {
                Console.Write(" ");
            }

            for (int col = 1; col < starCount; col++)
            {
                Console.Write("* ");
            }

            Console.WriteLine("*");
        }
    }
}
