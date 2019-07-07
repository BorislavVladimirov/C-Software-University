using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tempArr = input.Split(" -> ");

                string companyName = tempArr[0];
                string employeeId = tempArr[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(employeeId);
                }
                else if(companies.ContainsKey(companyName) && !companies[companyName].Contains(employeeId))
                {
                    companies[companyName].Add(employeeId);
                }

                input = Console.ReadLine();
            }
            foreach (var kvp in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var employee in kvp.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
