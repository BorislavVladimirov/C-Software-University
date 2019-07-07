using System;
using System.Globalization;

namespace SumOfDays
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);


            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    firstDate = firstDate.AddDays(1);
                }
                else if (i % 2 != 0)
                {
                    secondDate = secondDate.AddDays(1.0);
                }
            }
            int sumDays = firstDate.Day + secondDate.Day;

            Console.WriteLine(sumDays);
        }
    }
}
