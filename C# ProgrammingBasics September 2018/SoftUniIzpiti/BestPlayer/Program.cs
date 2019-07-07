using System;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxScore = int.MinValue;
            string nameOfBestPlayer = string.Empty;

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "END")
                {
                    break;
                }

                int goalScored = int.Parse(Console.ReadLine());

                if (goalScored > maxScore)
                {
                    maxScore = goalScored;
                    nameOfBestPlayer = name;                  
                }
                if (maxScore >= 10)
                {
                    break;
                }


            }
            Console.WriteLine($"{nameOfBestPlayer} is the best player!");
            if (maxScore >= 3)
            {
                Console.WriteLine($"He has scored {maxScore} goals and made a hat-trick !!!");

            }
            else
            {
                Console.WriteLine($"He has scored {maxScore} goals.");
            }
        }
    }
}
