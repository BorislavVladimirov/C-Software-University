using System;

namespace OddEvenPosition2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double OddSum = 0;
            double OddMin = 1000000000.0;
            double OddMax = -1000000000.0;
            double EvenSum = 0;
            double EvenMin = 1000000000.0;
            double EvenMax = -1000000000.0;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 1)
                {
                    OddSum += num;

                    if (num < OddMin)
                    {
                        OddMin = num;
                    }
                    if (num > OddMax)
                    {
                        OddMax = num;
                    }
                }
                else if (i % 2 == 0)
                {
                    EvenSum += num;

                    if (num < EvenMin)
                    {
                        EvenMin = num;
                    }
                    if (num > EvenMax)
                    {
                        EvenMax = num;
                    }
                }
            }
            if (n == 0)
            {
                Console.WriteLine($"OddSum={OddSum},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={EvenSum},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else if (EvenMin == 1000000000.0)
            {
                Console.WriteLine($"OddSum={OddSum},");
                Console.WriteLine($"OddMin={OddMin},");
                Console.WriteLine($"OddMax={OddMax},");
                Console.WriteLine($"EvenSum={EvenSum},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");                
            }
            else if (OddMin == 1000000000.0)
            {
                Console.WriteLine($"OddSum={OddSum},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={EvenSum},");
                Console.WriteLine($"EvenMin={EvenMin},");
                Console.WriteLine($"EvenMax={EvenMax}");
            }
            else
            {
                Console.WriteLine($"OddSum={OddSum},");
                Console.WriteLine($"OddMin={OddMin},");
                Console.WriteLine($"OddMax={OddMax},");
                Console.WriteLine($"EvenSum={EvenSum},");
                Console.WriteLine($"EvenMin={EvenMin},");
                Console.WriteLine($"EvenMax={EvenMax}");
            }

        }
    }
}
