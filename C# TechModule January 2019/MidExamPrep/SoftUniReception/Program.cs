using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmplyee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());

            int studentsCount = int.Parse(Console.ReadLine());

            int timeNeeded = 0;

            for (int i = 1; 0 < studentsCount; i++)
            {
                studentsCount -= (firstEmployee + secondEmplyee + thirdEmployee);

                if (i % 4 == 0)
                {
                    i++;
                }
                timeNeeded = i;
            }
            Console.WriteLine($"Time needed: {timeNeeded}h.");

        }
    }
}
