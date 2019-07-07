using System;

namespace TripToWorldCup
{
    class Program
    {
        static void Main(string[] args)
        {
            double goingTicketsPrice = double.Parse(Console.ReadLine());
            double backTicketsPrice = double.Parse(Console.ReadLine());
            double pricePerGame = double.Parse(Console.ReadLine());
            double gamesCount = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double totalTicketsMoney = 0;
            double totalPrice = 0;
            double pricePerPerson = 0;

            totalTicketsMoney = (goingTicketsPrice + backTicketsPrice) * 6;
            totalPrice = (totalTicketsMoney - (totalTicketsMoney * (discount * 0.01))) + ((pricePerGame * 6) * gamesCount);
            pricePerPerson = totalPrice / 6;

            Console.WriteLine($"Total sum: {totalPrice:f2} lv.");
            Console.WriteLine($"Each friend has to pay {pricePerPerson:f2} lv.");
        }
    }
}
