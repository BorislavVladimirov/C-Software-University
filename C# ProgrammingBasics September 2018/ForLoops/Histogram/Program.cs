using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double count1 = 0;
            double count2 = 0;
            double count3 = 0;
            double count4 = 0;
            double count5 = 0;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    count1++;
                }
                else if (num < 400)
                {
                    count2++;
                }
                else if (num < 600)
                {
                    count3++;
                }
                else if (num < 800)
                {
                    count4++;
                }
                else
                {
                    count5++;
                }

            }
            Console.WriteLine($"{((count1 / (n * 1.0)) * 100):f2}");
            Console.WriteLine($"{((count2 / (n * 1.0)) * 100):f2}");
            Console.WriteLine($"{((count3 / (n * 1.0)) * 100):f2}");
            Console.WriteLine($"{((count4 / (n * 1.0)) * 100):f2}");
            Console.WriteLine($"{((count5 / (n * 1.0)) * 100):f2}");
        }
    }
}
