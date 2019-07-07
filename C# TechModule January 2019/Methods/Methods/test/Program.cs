using System;

namespace topNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintingMasterNumbers(n);
        }

        private static void PrintingMasterNumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                int currentDigit = 0;

                int currentNumber = i;
                int num = i;

                while (num > 0)
                {
                    currentDigit = num % 10;
                    sumOfDigits += currentDigit;
                    num /= 10;
                }
                if (sumOfDigits % 8 == 0)
                {
                    while (currentNumber > 0)
                    {
                        currentDigit = currentNumber % 10;

                        if (currentDigit % 2 != 0)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                        currentNumber /= 10;
                    }
                }
            }
        }
    }
}
