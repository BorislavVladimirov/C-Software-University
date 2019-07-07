using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var companies = new Dictionary<string, List<string>>();

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
                else
                {
                    if (!companies[companyName].Contains(employeeId))
                    {   
                        companies[companyName].Add(employeeId);
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var company in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine(company.Key);

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}