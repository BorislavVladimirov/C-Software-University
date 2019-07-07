using System;

namespace EqualSumsLeftRightPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                GetSum(i);
            }

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                GetSum(i);
            }

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                GetSum(i);
            }
        }

        public static void GetSum(int i)
        {
            int leftSum = 0;
            int rightSum = 0;
            int middleNum = 0;
            int currentNum = i;

            for (int y = 5; y >= 1; y--)
            {
                switch (y)
                {
                    case 5:
                    case 4:
                        rightSum += currentNum % 10;
                        break;
                    case 3:
                        middleNum = currentNum % 10;
                        break;
                    case 2:
                    case 1:
                        leftSum += currentNum % 10;
                        break;
                }
                currentNum /= 10;
            }

            if (leftSum < rightSum)
            {
                leftSum += middleNum;
            }
            else if (rightSum < leftSum)
            {
                rightSum += middleNum;
            }
            if (leftSum == rightSum)
            {
                Console.Write("{0} ", i);
                Console.WriteLine();
            }
        }
    }
}
