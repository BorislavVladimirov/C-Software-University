using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupTipe = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double currentPrice = 0;

            switch (dayOfWeek)
            {
                case "Friday":
                    if (groupTipe == "Students")
                    {
                        currentPrice = 8.45 * peopleCount;
                        if (peopleCount >= 30)
                        {
                            currentPrice *= 0.85;
                        }
                    }
                    else if (groupTipe == "Business")
                    {
                        currentPrice = 10.9 * peopleCount;
                        if (peopleCount >= 100)
                        {
                            peopleCount = peopleCount - 10;
                            currentPrice = 10.9 * peopleCount;
                        }
                    }
                    else if (groupTipe == "Regular")
                    {
                        currentPrice = 15 * peopleCount;
                        if (peopleCount >= 10 && peopleCount <= 20)
                        {
                            currentPrice *= 0.95;
                        }
                    }
                    break;

                case "Saturday":
                    if (groupTipe == "Students")
                    {
                        currentPrice = 9.80 * peopleCount;
                        if (peopleCount >= 30)
                        {
                            currentPrice *= 0.85;
                        }
                    }
                    else if (groupTipe == "Business")
                    {
                        currentPrice = 15.6 * peopleCount;
                        if (peopleCount >= 100)
                        {
                            peopleCount = peopleCount - 10;
                            currentPrice = 15.6 * peopleCount;
                        }
                    }
                    else if (groupTipe == "Regular")
                    {
                        currentPrice = 20 * peopleCount;
                        if (peopleCount >= 10 && peopleCount <= 20)
                        {
                            currentPrice *= 0.95;
                        }
                    }
                    break;

                case "Sunday":
                    if (groupTipe == "Students")
                    {
                        currentPrice = 10.46 * peopleCount;
                        if (peopleCount >= 30)
                        {
                            currentPrice *= 0.85;
                        }
                    }
                    else if (groupTipe == "Business")
                    {
                        currentPrice = 16 * peopleCount;
                        if (peopleCount >= 100)
                        {
                            peopleCount = peopleCount - 10;
                            currentPrice = 16 * peopleCount;
                        }
                    }
                    else if (groupTipe == "Regular")
                    {
                        currentPrice = 22.5 * peopleCount;
                        if (peopleCount >= 10 && peopleCount <= 20)
                        {
                            currentPrice *= 0.95;
                        }
                    }
                    break;
            }
            Console.WriteLine($"Total price: {currentPrice:f2}");
        }
    }
}
