using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Grade = grade
                };

                students.Add(student);
            }
            List<Student> ordered = students.OrderByDescending(x => x.Grade).ToList();

            foreach (Student CurrentStudent in ordered)
            {
                Console.WriteLine($"{CurrentStudent.FirstName} {CurrentStudent.LastName}: {CurrentStudent.Grade:f2}");
            }
        }
    }
}
