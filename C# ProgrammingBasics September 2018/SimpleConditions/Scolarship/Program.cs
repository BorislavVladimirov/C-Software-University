using System;

namespace Scolarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScholarship = 0;
            double excellentScholarship = 0;

            if (income < minSalary && averageGrade >= 5.5)
            {
                socialScholarship = minSalary * 0.35;
                excellentScholarship = averageGrade * 25;
            }
            else if (income < minSalary && averageGrade > 4.5)
            {
                socialScholarship = minSalary * 0.35;
            }
            else if (averageGrade >= 5.5)
            {
                excellentScholarship = averageGrade * 25;
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
                return;
            }
            if (socialScholarship > excellentScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else if (excellentScholarship >= socialScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
            }
        }
    }
}
