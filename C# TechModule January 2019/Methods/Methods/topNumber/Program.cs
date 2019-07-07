using System;

namespace topNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = GetSumt(i);

                if (sum % 8 == 0)
                {
                    if (IsOddDigit(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        private static bool IsOddDigit(int i)
        {
            while (i > 0)
            {
                int digit = i % 10;

                if (digit % 2 != 0)
                {
                    return true;
                }
                i /= 10;
            }

            return false;
        }

        private static int GetSumt(int i)
        {
            int result = 0;

            while (i > 0)
            {
                result += i % 10;
                i /= 10;
            }
            
            return result;
        }
    }
}
