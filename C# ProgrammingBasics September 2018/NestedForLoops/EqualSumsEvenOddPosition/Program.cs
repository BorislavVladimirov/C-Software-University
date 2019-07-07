using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;
            int currentNum = 0;

            for (int i = num1; i <= num2; i++)
            {
                currentNum = i;

                for (int j = 1; j <= 6; j++)
                {
                    int lastNum = currentNum % 10;
                    currentNum = (currentNum - lastNum) / 10;

                    if (j % 2 == 0)
                    {
                        evenSum += lastNum;
                    }
                    else
                    {
                        oddSum += lastNum;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write($"{i} ");
                }
                evenSum = 0;
                oddSum = 0;
            }
        }
    }
}
