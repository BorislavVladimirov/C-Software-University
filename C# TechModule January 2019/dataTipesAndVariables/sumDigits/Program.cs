using System;

namespace sumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNumber = 0;

            while (number > 0)
            {
                currentNumber = number % 10;
                sum += currentNumber;
                number /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
