using System;

namespace ComputerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rating = 0;
            double salesPossible = 0;
            double pcCount = 0;
            double totalRating = 0;
            double newNem = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                pcCount++;
                newNem = num / 10;

                if (num % 10 == 2)
                {
                    rating = 2;
                    salesPossible = salesPossible + newNem * 0;
                    totalRating += 2;
                }
                else if (num % 10 == 3)
                {
                    rating = 3;
                    salesPossible = salesPossible + newNem * 0.5;
                    totalRating += 3;
                }
                else if (num % 10 == 4)
                {
                    rating = 4;
                    salesPossible = salesPossible + newNem * 0.7;
                    totalRating += 4;
                }
                else if (num % 10 == 5)
                {
                    rating = 5;
                    salesPossible = salesPossible + newNem * 0.85;
                    totalRating += 5;
                }
                else if (num % 10 == 6)
                {
                    rating = 6;
                    salesPossible = salesPossible + newNem;
                    totalRating += 6;
                }

            }
            double avgRating = totalRating / pcCount;
            Console.WriteLine($"{salesPossible:f2}");
            Console.WriteLine($"{avgRating:f2}");
        }
    }
}
