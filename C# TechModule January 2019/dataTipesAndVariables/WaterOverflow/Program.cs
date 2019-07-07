using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int n = int.Parse(Console.ReadLine());
            int litersInTank = 0;
            for (int i = 0; i < n; i++)
            {
                int litersToPour = int.Parse(Console.ReadLine());
                
                if (capacity >= litersToPour)
                {
                    litersInTank += litersToPour;
                    capacity -= litersToPour;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(litersInTank);
        }
    }
}
