using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int powerNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(number, powerNumber)); 
        }
        static double MathPower(double number, int powerNumber)
        {
            double result = 1;

            for (int i = 0; i < powerNumber; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
