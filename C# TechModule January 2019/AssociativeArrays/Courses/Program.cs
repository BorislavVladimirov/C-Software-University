using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tempArr = input.Split(" : ");

                string course = tempArr[0];
                string studentName = tempArr[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                    courses[course].Add(studentName);
                }
                else if(courses.ContainsKey(course))
                {
                    courses[course].Add(studentName);
                }

                input = Console.ReadLine();
            }
            foreach (var kvp in courses.OrderByDescending(x => x.Value.Count))
            {
                int count = kvp.Value.Count;

                Console.WriteLine($"{kvp.Key}: {count}");

                foreach (var student in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
                
            }
        }
    }
}
