using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int wight = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string input;
            
            double spaceVolume = wight * lenght * height;
            double boxesVolume = 0;

            while (true)
            {
                input = Console.ReadLine();

                

                if (input == "Done" || spaceVolume <= boxesVolume)
                {
                    if (spaceVolume < boxesVolume)
                    {
                        double diffr = boxesVolume - spaceVolume;
                        Console.WriteLine($"No more free space! You need {diffr} Cubic meters more.");
                        return;
                    }
                    double diff = spaceVolume - boxesVolume;
                    Console.WriteLine($"{diff} Cubic meters left.");
                    break;
                }int boxesCount = int.Parse(input);
                boxesVolume = boxesVolume + boxesCount;
            }
            if (spaceVolume < boxesVolume)
            {
                double diff = boxesVolume - spaceVolume;
                Console.WriteLine($"No more free space! You need {diff} Cubic meters more.");
            }
        }
    }
}
