using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int numOfFlowrs = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double moneyNeeded = 0;
            double moneyleft = 0;

            if (typeOfFlowers == "Roses")
            {
                if (numOfFlowrs > 80)
                {
                    moneyNeeded = (numOfFlowrs * 5) * 0.9;
                }
                else if (numOfFlowrs <= 80)
                {
                    moneyNeeded = numOfFlowrs * 5;
                }

                moneyleft = budget - moneyNeeded;
            }
            else if (typeOfFlowers == "Dahlias")
            {
                if (numOfFlowrs > 90)
                {
                    moneyNeeded = (numOfFlowrs * 3.80) * 0.85;
                }
                else if (numOfFlowrs <= 90)
                {
                    moneyNeeded = numOfFlowrs * 3.80;
                }

                moneyleft = budget - moneyNeeded;
            }
            else if (typeOfFlowers == "Tulips")
            {
                if (numOfFlowrs > 80)
                {
                    moneyNeeded = (numOfFlowrs * 2.80) * 0.85;
                }
                else if (numOfFlowrs <= 90)
                {
                    moneyNeeded = numOfFlowrs * 2.80;
                }

                moneyleft = budget - moneyNeeded;
            }
            else if (typeOfFlowers == "Narcissus")
            {
                if (numOfFlowrs < 120)
                {
                    moneyNeeded = (numOfFlowrs * 3) * 1.15;
                }
                else if (numOfFlowrs >= 120)
                {
                    moneyNeeded = numOfFlowrs * 3;
                }

                moneyleft = budget - moneyNeeded;
            }
            else if (typeOfFlowers == "Gladiolus")
            {
                if (numOfFlowrs < 80)
                {
                    moneyNeeded = (numOfFlowrs * 2.50) * 1.20;
                }
                else if (numOfFlowrs >= 80)
                {
                    moneyNeeded = numOfFlowrs * 2.50;
                }

                moneyleft = budget - moneyNeeded;
            }
            if (moneyleft >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowrs} {typeOfFlowers} and {moneyleft:f2} leva left.");
            }
            else if (moneyleft < 0)
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(moneyleft):f2} leva more.");
            }
        }
    }
}
