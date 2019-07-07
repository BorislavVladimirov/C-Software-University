using System;
using System.Collections.Generic;

namespace BonusSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentsCount = double.Parse(Console.ReadLine());
            double lectureCount = double.Parse(Console.ReadLine());
            double initialBonus = double.Parse(Console.ReadLine());

            Dictionary<double, double> student = new Dictionary<double, double>();

            double maxBonusScore = double.MinValue;

            for (int i = 0; i < studentsCount; i++)
            {
                double attendances = double.Parse(Console.ReadLine());

                double tempMaxScore = Math.Ceiling(attendances / lectureCount * (5.0 + initialBonus));

                if (tempMaxScore > maxBonusScore)
                {
                    student.Clear();

                    student.Add(tempMaxScore, attendances);

                    maxBonusScore = tempMaxScore;
                }
            }
            foreach (var item in student)
            {
                Console.WriteLine($"The maximum bonus score for this course is {item.Key}.The student has attended {item.Value} lectures.");
            }
        }
    }
}
