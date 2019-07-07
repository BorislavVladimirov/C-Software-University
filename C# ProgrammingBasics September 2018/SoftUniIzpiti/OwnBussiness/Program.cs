using System;

namespace OwnBussiness
{
    class Program
    {
        static void Main(string[] args)
        {
            int wight = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            int freeSpace = 0;
            int placeSize = 0;
            int computersCount = 0;
            placeSize = wight * lenght * hight;
            freeSpace = placeSize;
            while (true)
            {

                string input = Console.ReadLine();

                if (input == "Done")
                {                   
                    Console.WriteLine($"{Math.Abs(freeSpace)} Cubic meters left.");
                    break;
                }
                 computersCount = int.Parse(input);

                
                freeSpace = freeSpace - computersCount;

                if (freeSpace <= 0)
                {                    
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
                    break;
                }
            }
        }
    }
}
