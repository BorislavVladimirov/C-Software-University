    using System;

    namespace WhileLoops
    {
        class Program
        {
            static void Main(string[] args)
            {
                
                string name = Console.ReadLine();
                int gradesCount = 0;
                double gradesSum = 0;

                while (gradesCount < 12)
                {
                    
                    double currentGrade = double.Parse(Console.ReadLine());

                    if (currentGrade >= 4)
                    {
                        gradesSum = gradesSum + currentGrade;
                        gradesCount++;
                    }
                }
                double avgGrade = gradesSum / 12;

                if (avgGrade > 4)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {avgGrade:f2}");
                }
            
            }
        }
    }
