using System;

namespace usingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes +=30;

            if (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }
            if (hours > 23)
            {
                Console.WriteLine($"0:{minutes:D2}");
                return;
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
