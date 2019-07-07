using System;

namespace CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batchCount = int.Parse(Console.ReadLine());

            for (int currentBatchNumber = 1; currentBatchNumber <= batchCount; currentBatchNumber++)
            {
                bool isFlourPresent = false;
                bool isEggsPresent = false;
                bool isSugarPresent = false;

                string productName = Console.ReadLine().ToLower();

                while (true)
                {
                    if (productName == "eggs")
                    {
                        isEggsPresent = true;
                    }
                    else if (productName == "flour")
                    {
                        isFlourPresent = true;
                    }
                    else if (productName == "sugar")
                    {
                        isSugarPresent = true;
                    }
                    else if (productName == "bake!")
                    {
                        if (isFlourPresent == true && isEggsPresent == true && isSugarPresent == true)
                        {
                            break;
                        }
                        else 
                        {
                            Console.WriteLine($"The batter should contain flour, eggs and sugar!");
                        }
                    }

                    productName = Console.ReadLine().ToLower();
                    
                }
                Console.WriteLine($"Baking batch number {currentBatchNumber}...");                

            }
        }
    }
}
