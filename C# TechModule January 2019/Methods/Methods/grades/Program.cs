using System;

namespace grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            ReceiveAndPrintGrade(grade);
        }
        static void ReceiveAndPrintGrade(double grade)
        {
            
            string gradeInWords = string.Empty;

            if (grade >= 2 && grade < 3)
            {
                gradeInWords = "Fail";
            }
            else if (grade < 3.50)
            {
                gradeInWords = "Poor";
            }
            else if (grade < 4.50)
            {
                gradeInWords = "Good";
            }
            else if (grade < 5.50)
            {
                gradeInWords = "Very good";
            }
            else if (grade <= 6)
            {
                gradeInWords = "Excellent";
            }
            Console.WriteLine(gradeInWords);
        }
        
    }
}
