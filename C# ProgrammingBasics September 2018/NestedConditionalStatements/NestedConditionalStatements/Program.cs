using System;

namespace NestedConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 6;
            bool isEven = (6 % 2) == 0;
            if ((5 < number && number < 10) && isEven)
            {
                Console.WriteLine("Today is not your birthday!");
            }

            //чрез скоби () можем да приотизираме действия.
            // if ((a > 3 %% a < 10) && a != 19)
        }
    }
}
