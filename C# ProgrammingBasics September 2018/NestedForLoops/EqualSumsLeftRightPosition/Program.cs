using System;

namespace EqualSumsLeftRightPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;
            int middleNum = 0;
            int currentNum = 0;
            int number = 0;


            for (int i = num1; i <= num2; i++)
            {
                currentNum = i;
                int right = currentNum % 100 / 10;
                int right2 = currentNum % 10;

                int left = currentNum / 10000 % 10;
                int left2 = currentNum / 1000 % 10;

                int middle = currentNum / 100 % 10;

                leftSum = left + left2;
                rightSum = right + right2;

                if (leftSum < rightSum)
                {
                    leftSum += middle;
                }
                else if (rightSum < leftSum)
                {
                    rightSum += middle;
                }
                if (rightSum == leftSum)
                {
                    Console.Write($"{i} ");
                }

            }
        }
    }
}
