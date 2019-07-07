using System;

namespace GraduationPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int timesGradeIsUnder4 = 0;
            double gradesSum = 0;
            int gradesCount = 0;
            double avgGrade = 1;

            while (gradesCount < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                                

                if (grade < 4)
                {
                    timesGradeIsUnder4++;
                    gradesCount++;
                }
                if (timesGradeIsUnder4 > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {gradesCount -1} grade");
                    return;
                }
                if (grade >= 4) 
                {
                    gradesSum = gradesSum + grade;
                    gradesCount++;
                }

                 avgGrade = gradesSum / 12;


            }
            Console.WriteLine($"{name} graduated. Average grade: {avgGrade:f2}");
        }
    }
}
