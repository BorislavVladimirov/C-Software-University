using System;

namespace Hogswatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int homesCount = int.Parse(Console.ReadLine());

            int presentsCount = int.Parse(Console.ReadLine());

            int initialPresentsCount = presentsCount;
            int timesWentBack = 0;
            int additionalPresents = 0;

            for (int i = 1; i <= homesCount; i++)
            {
                int childrenCount = int.Parse(Console.ReadLine());

                presentsCount -= childrenCount;

                if (presentsCount < 0)
                {
                    int temp = presentsCount;
                    timesWentBack++;
                    additionalPresents += ((initialPresentsCount / i) * (homesCount - i)) + (Math.Abs(temp));
                    presentsCount = 0;
                    presentsCount +=((initialPresentsCount / i) * (homesCount - i)) + (Math.Abs(temp));
                    presentsCount -= Math.Abs(temp);
                }
            }
            if (timesWentBack == 0)
            {
                Console.WriteLine(presentsCount);
            }
            else
            {
                Console.WriteLine(timesWentBack);
                Console.WriteLine(additionalPresents);
            }
        }
    }
}
