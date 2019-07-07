using System;

namespace refactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                bool isTrue = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isTrue = false;
                        break;
                    }
                }
                string istrue = isTrue.ToString().ToLower();
                Console.WriteLine($"{i} -> {istrue}");
            }

        }
    }
}
