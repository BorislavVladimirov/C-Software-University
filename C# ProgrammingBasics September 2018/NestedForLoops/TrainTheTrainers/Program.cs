using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            double currentPresentationGrade = 0;
            string presentationName = "";
            int gradesCount = 0;
            double totalGradesSum = 0;

            while ((presentationName = Console.ReadLine()) != "Finish")
            {

                currentPresentationGrade = 0;

                for (int i = 0; i < judges; i++)
                {
                    currentPresentationGrade += double.Parse(Console.ReadLine());
                    
                    gradesCount++;
                }
                totalGradesSum += currentPresentationGrade;

                double averageGradeSum = currentPresentationGrade / judges;

                Console.WriteLine($"{presentationName} - {averageGradeSum:f2}.");
                averageGradeSum = 0;
            }
            Console.WriteLine($"Student's final assessment is {totalGradesSum / gradesCount:f2}.");
        }
    }
}
