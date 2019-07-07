using System;

namespace mathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double powerNumber = int.Parse(Console.ReadLine());
            double result = MathPwer(number, powerNumber);

            Console.WriteLine(result);
        }

        private static double MathPwer(double number, double powerNumber)
        {
            return Math.Pow(number, powerNumber);
        }
    }
}
