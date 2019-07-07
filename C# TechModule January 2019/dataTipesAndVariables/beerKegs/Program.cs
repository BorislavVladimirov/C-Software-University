using System;
using System.Numerics;
namespace beerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestKegVolume = double.MinValue;
            double volume = 0;
            string currentBiggestModel = "";
            
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = (Math.PI * (Math.Pow(radius,2))) * height;

                if (volume > biggestKegVolume)
                {
                    currentBiggestModel = model;
                    biggestKegVolume = volume;
                }
            }
            Console.WriteLine(currentBiggestModel);
        }
    }
}
