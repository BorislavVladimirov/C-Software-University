using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<Employee>> company = new Dictionary<string, List<Employee>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] tempArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = tempArr[0];
                decimal salary = decimal.Parse(tempArr[1]);
                string position = tempArr[2];
                string  department = tempArr[3];
                int age = -1;
                string email = "n/a";

                for (int y = 4; y < tempArr.Length; y++)
                {
                    if (int.TryParse(tempArr[y], out int newAge))
                    {
                        age = newAge;
                    }
                    else
                    {
                        email = tempArr[y];
                    }
                }

                Employee employee = new Employee(name, salary, position, department, age, email);

                if (!company.ContainsKey(department))
                {
                    company[department] = new List<Employee>();
                }

                company[department].Add(employee);
            }

            var toPrint = company.OrderByDescending(x => x.Value.Sum(e => e.Salary)).FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {toPrint.Key}");

            foreach (var item in toPrint.Value.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{item.Name} {item.Salary:f2} {item.Email} {item.Age}");
            }
        }
    }
}
