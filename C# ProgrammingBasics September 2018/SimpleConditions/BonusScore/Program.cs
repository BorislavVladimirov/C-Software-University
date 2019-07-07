using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonusPoint = 0;
            

            if (number <=  100)
            {
                bonusPoint = 5;
            }
            else if (number > 100 && number < 1000)
            {
                bonusPoint = number * 0.2;
            }
            else if (number > 1000)
            {
                bonusPoint = number * 0.1;
            }
            if (number % 2 == 0)
            {
                bonusPoint += 1;
            }
            else if (number % 10 == 5)
            {
                bonusPoint += 2;
            }
            double totalPoint = number + bonusPoint;
            Console.WriteLine(bonusPoint);
            Console.WriteLine(totalPoint);
        }
    }
}
