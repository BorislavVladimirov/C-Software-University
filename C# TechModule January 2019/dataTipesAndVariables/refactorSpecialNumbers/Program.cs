using System;

namespace refactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isTrue = false;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = i;

                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                isTrue = (sum == 5) || (sum == 7) || (sum == 11);

                number = i;
                Console.WriteLine("{0} -> {1}", number, isTrue);
                sum = 0;

            }
        }
    }
}
