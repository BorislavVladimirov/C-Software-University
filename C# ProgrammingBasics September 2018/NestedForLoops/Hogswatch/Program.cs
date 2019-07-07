using System;

namespace Hogswatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int homesToVisit = int.Parse(Console.ReadLine());
            int numberOfPresents = int.Parse(Console.ReadLine());

            int initialPresentsCount = numberOfPresents;

            int wentBackToRefill = 0;
            int presentsRefilled = 0;
            int presentsNeeded = 0;
            int additionalPresentsCount = 0;

            for (int i = 1; i <= homesToVisit; i++)
            {
                int childrenPerHouse = int.Parse(Console.ReadLine());
                
                if (numberOfPresents < childrenPerHouse)
                {
                    presentsNeeded = childrenPerHouse - numberOfPresents;
                    wentBackToRefill++;

                    presentsRefilled = (initialPresentsCount / i) * (homesToVisit - i) + presentsNeeded;
                    additionalPresentsCount += presentsRefilled;
                    numberOfPresents += presentsRefilled;
                    numberOfPresents -= childrenPerHouse;
                }
                else
                {
                    numberOfPresents -= childrenPerHouse;
                }
            }
            if (wentBackToRefill == 0)
            {
                Console.WriteLine(numberOfPresents);
            }
            else
            {
                Console.WriteLine($"{wentBackToRefill}");
                Console.WriteLine($"{additionalPresentsCount}");
            }
        }
    }
}
