using System;

namespace MethodsAndDebugging
{
    public class Program
    {
        static void Main(string[] args)
        {
            Grades(grade: 4.5);
        }
        static void Grades(double grade)
        {
            if (grade < 3 && grade > 2)
            {
                Console.WriteLine("Fail");
            }
            else if (grade < 3.5)
            {
                Console.WriteLine("Poor");
            }
            else if (grade < 4.5)
            {
                Console.WriteLine("Good");
            }
            else if (grade < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else if(grade <= 6)
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                Console.WriteLine("Index Out Of Range Exception");
                Console.WriteLine("Line 9");
            }
        }
    }
}
