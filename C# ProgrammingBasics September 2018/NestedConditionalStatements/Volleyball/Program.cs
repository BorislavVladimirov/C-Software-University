using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsInHomeTown = int.Parse(Console.ReadLine());


            if (typeOfYear == "normal")
            {
                double weekendsPlayedInSofia = (48 - weekendsInHomeTown) * (3.0 / 4.0);
                double gamesPlayedInHomeTown = weekendsInHomeTown;
                double gamesPlayedInHolidays = holidays * (2.0 / 3.0);

                double totalGamesPlayed = weekendsPlayedInSofia + gamesPlayedInHomeTown + gamesPlayedInHolidays;
                Console.WriteLine($"{Math.Truncate(totalGamesPlayed)}");
            }
            else if (typeOfYear == "leap")
            {
                double weekendsPlayedInSofia = (48 - weekendsInHomeTown) * (3.0 / 4.0);
                double gamesPlayedInHomeTown = weekendsInHomeTown;
                double gamesPlayedInHolidays = holidays * (2.0 / 3.0);

                double totalGamesPlayed = (weekendsPlayedInSofia + gamesPlayedInHomeTown + gamesPlayedInHolidays) * 1.15;
                Console.WriteLine($"{Math.Truncate(totalGamesPlayed)}");
            }
            
        }
    }
}
