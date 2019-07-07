using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            double num = 0;

            for (int i = 1; i <= n; i++)
            {
                num = double.Parse(Console.ReadLine());

                if (i % 2 == 1)
                {
                    oddSum = oddSum + num;

                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }

                }
                else if (i % 2 == 0)
                {

                    evenSum = evenSum + num;

                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }


                }

            }
            if (num == 0)
            {
                Console.WriteLine($"OddSum = {oddSum},");
                Console.WriteLine($"OddMin = No,");
                Console.WriteLine($"OddMax = No,");
                Console.WriteLine($"EvenSum = {evenSum},");
                Console.WriteLine($"EvenMin = No,");
                Console.WriteLine($"EvenMax = No");
            }
            else if (n == 1)
            {
                Console.WriteLine($"OddSum = {oddSum},");
                Console.WriteLine($"OddMin = {oddMin},");
                Console.WriteLine($"OddMax = {oddMax},");
                Console.WriteLine($"EvenSum = {evenSum},");
                Console.WriteLine($"EvenMin = No,");
                Console.WriteLine($"EvenMax = No");
            }
            else
            {
                Console.WriteLine($"OddSum = {oddSum},");
                Console.WriteLine($"OddMin = {oddMin},");
                Console.WriteLine($"OddMax = {oddMax},");
                Console.WriteLine($"EvenSum = {evenSum},");
                Console.WriteLine($"EvenMin = {evenMin},");
                Console.WriteLine($"EvenMax = {evenMax}");

            }
            




        }
    }
}
