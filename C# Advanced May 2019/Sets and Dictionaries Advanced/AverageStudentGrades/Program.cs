using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currentStudent = input[0];
                double grade = double.Parse(input[1]);

                if (!students.ContainsKey(currentStudent))
                {
                    students.Add(currentStudent, new List<double>());
                    students[currentStudent].Add(grade);
                }
                else
                {
                    students[currentStudent].Add(grade);
                }
            }
            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
