using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            int goal = 10000;

            int currentStepsCount = 0;

            while (currentStepsCount < goal)
            {
                input = Console.ReadLine();

                if (input == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    currentStepsCount = currentStepsCount + stepsToHome;
                    break;
                }
                else
                {
                    int stepsMade = int.Parse(input);
                    currentStepsCount = currentStepsCount + stepsMade;
                }
            }
            if (currentStepsCount >= goal)
            {
                Console.WriteLine("Goal reached! Good job!" );
            }
            else
            {
                int stepsLeft = goal - currentStepsCount;
                Console.WriteLine($"{stepsLeft} more steps to reach goal.");
            }
        }
    }
}
