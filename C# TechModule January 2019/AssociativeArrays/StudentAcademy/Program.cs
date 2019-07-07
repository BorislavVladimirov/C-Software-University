using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {

            var students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                    students[name].Add(grade); 
                }
                else
                {
                    students[name].Add(grade); 
                }
            }
            foreach (var student in students.Where(x => x.Value.Average() >= 4.5)
                .OrderByDescending(x => x.Value.Average()))
            {
                Console.WriteLine($"{student.Key} -> {(student.Value.Average()):f2}");
            }
        }
    }
}
