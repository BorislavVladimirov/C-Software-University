using System;
using System.Globalization;

namespace DateTimess
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            DateTime f = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
            DateTime s = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    f= f.AddDays(1);
                }
                else
                {
                   s = s.AddDays(1);
                }

            }
            int sum = f.Day + s.Day;
            Console.WriteLine(sum);
        }
    }
}
