using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputToArr = input.Split();

                string firstName = inputToArr[0];
                string lastName = inputToArr[1];
                int age = int.Parse(inputToArr[2]);
                string hometown = inputToArr[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = hometown
                };

                students.Add(student);

                input = Console.ReadLine();
            }
            string cityToCompare = Console.ReadLine();

            List<Student> filteredStudents = students.Where(x => x.HomeTown == cityToCompare).ToList();

            foreach (var item in filteredStudents)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
            }
        }
    }

}
