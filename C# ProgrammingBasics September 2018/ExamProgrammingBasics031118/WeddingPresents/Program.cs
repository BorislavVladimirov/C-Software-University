using System;

namespace WeddingPresents
{
    class Program
    {
        static void Main(string[] args)
        {
            double guestsCount = int.Parse(Console.ReadLine());
            double presentsCount = int.Parse(Console.ReadLine());

            double aCount = 0;
            double bCount = 0;
            double vCount = 0;
            double gCount = 0;

            for (int i = 0; i < presentsCount; i++)
            {
                string typeOfPresent = Console.ReadLine();

                switch (typeOfPresent)
                {
                    case "A":
                        aCount++;
                        break;
                    case "B":
                        bCount++;
                        break;
                    case "V":
                        vCount++;
                        break;
                    case "G":
                        gCount++;
                        break;
                }
            }
            Console.WriteLine($"{(aCount / presentsCount)* 100:f2}%");
            Console.WriteLine($"{(bCount / presentsCount)* 100:f2}%");
            Console.WriteLine($"{(vCount / presentsCount)* 100:f2}%");
            Console.WriteLine($"{(gCount / presentsCount)* 100:f2}%");
            Console.WriteLine($"{(presentsCount / guestsCount) * 100:f2}%");
        }
    }
}
