using System;

namespace BuildingThirdTime
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int floors = n1; floors > 0; floors--)
            {
                for (int aparment = 0; aparment < n2; aparment++)
                {
                    if (floors % 2 == 0 && floors != n1)
                    {
                        Console.Write($"O{floors}{aparment} ");
                    }
                    else if (floors % 2 == 1 && floors != n1)
                    {
                        Console.Write($"A{floors}{aparment} ");
                    }
                    if (floors == n1)
                    {
                        Console.Write($"L{floors}{aparment} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
