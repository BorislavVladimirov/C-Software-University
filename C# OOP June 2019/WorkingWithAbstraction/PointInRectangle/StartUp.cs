using System;
using System.Linq;

namespace PointInRectangle
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] coordinates = ParseInput();

            int n = int.Parse(Console.ReadLine());

            Point topLeft = new Point(coordinates[0], coordinates[1]);
            Point bottomRight = new Point(coordinates[2], coordinates[3]);

            Rectangle rectangle = new Rectangle(topLeft, bottomRight);

            for (int i = 0; i < n; i++)
            {
                int[] point = ParseInput();

                Point pointToCheck = new Point(point[0], point[1]);

                Console.WriteLine(rectangle.Contains(pointToCheck));
            }
        }

        private static int[] ParseInput()
        {
            return Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
